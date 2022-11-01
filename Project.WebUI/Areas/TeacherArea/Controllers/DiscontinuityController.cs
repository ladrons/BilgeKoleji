using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.WebUI.Areas.TeacherArea.Data.TeacherVMClasses;
using Project.WebUI.Tools.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.WebUI.Areas.TeacherArea.Controllers
{
    [TeacherAuth]
    public class DiscontinuityController : Controller
    {
        ClassroomRepository _classroomRep; StudentRepository _studentRep; AbsenteeismRepository _absenteeismRep;

        TeacherAndClassroomRepository _teacherAndClassroomRep;

        public DiscontinuityController()
        {
            _classroomRep = new ClassroomRepository();
            _studentRep = new StudentRepository();
            _absenteeismRep = new AbsenteeismRepository();

            _teacherAndClassroomRep = new TeacherAndClassroomRepository();
        }

        //--\\ //--\\ //--\\ //--\\

        /// <summary>
        /// Sisteme giriş yapan öğretmenin ders verdiği sınıfları listeler.
        /// </summary>
        /// <returns></returns>
        public ActionResult ListClassroom()
        {
            Teacher teacher = (Session["teacher"] as Teacher);

            ClassroomVM cvm = new ClassroomVM
            {
                Classrooms = _teacherAndClassroomRep.Where(x => x.TeacherID == teacher.ID).Select(x => x.Classroom).ToList()
            };

            TempData["ActiveTeacher"] = $"{teacher.Firstname} {teacher.Lastname}.";

            return View(cvm);
        }

        /// <summary>
        /// Seçilmiş olan sınıfın içerisindeki  listeler.
        /// </summary>
        /// <returns></returns>
        public ActionResult ListStudentInClassroom(int id)
        {
            ClassroomVM cvm = new ClassroomVM { Classroom = _classroomRep.Find(id) };

            return View(cvm);
        }

        /// <summary>
        /// Seçili öğrencinin sistemde kayıtlı olan bütün devamsızlık bilgilerini listeler.
        /// </summary>
        /// <returns></returns>
        public ActionResult ListStudentDiscontinuity(int id)
        {
            DiscontinuityVM dvm = new DiscontinuityVM
            {
                Teacher = (Session["teacher"] as Teacher),
                Student = _studentRep.Find(id),
                Absenteeisms = _absenteeismRep.Where(x => x.StudentID == id && x.Status != ENTITIES.Enums.DataStatus.Deleted).ToList(),

                DiscontinuityDTO = new ConsumeDTO.DiscontinuityDTO()
            };

            return View(dvm);
        }

        //--\\ //--\\ //--\\ //--\\

        /// <summary>
        /// Seçilmiş olan öğrenciye devamsızlık bilgisi ekleme işlemlerini sağlar.
        /// </summary>
        /// <returns></returns>
        public ActionResult AddDiscontinuity(int id)
        {
            DiscontinuityVM dvm = new DiscontinuityVM
            {
                Student = _studentRep.Find(id),
                DiscontinuityDTO = new ConsumeDTO.DiscontinuityDTO()
            };

            return View(dvm);
        }
        [HttpPost]
        public ActionResult AddDiscontinuity(DiscontinuityVM dvm)
        {
            Absenteeism absenteeism = new Absenteeism();

            if (dvm.DiscontinuityDTO.StartingDate >= DateTime.Now && dvm.DiscontinuityDTO.StartingDate != null)
            {
                absenteeism.StartingDate = Convert.ToDateTime(dvm.DiscontinuityDTO.StartingDate);

                if (dvm.DiscontinuityDTO.EndingDate >= absenteeism.StartingDate && dvm.DiscontinuityDTO.EndingDate != null)
                {
                    absenteeism.EndingDate = Convert.ToDateTime(dvm.DiscontinuityDTO.EndingDate);

                    TimeSpan timeSpan = absenteeism.EndingDate - absenteeism.StartingDate;
                    absenteeism.AbsencesCount = Convert.ToInt32(timeSpan.TotalDays) + 1;

                    Student student = _studentRep.Find(dvm.Student.ID);

                    if (dvm.DiscontinuityDTO.ReasonForAbsenteeism == "SentryStudent") //Özürlü devamsızlık
                    {
                        absenteeism.Description = $"{student.Firstname} İsimli öğrenci {absenteeism.StartingDate.ToShortDateString()} - {absenteeism.EndingDate.ToShortDateString()} tarihleri arasında nöbetçidir.";
                        absenteeism.AbsencesStatus = ENTITIES.Enums.AbsencesStatus.Excused;
                    }
                    else if (dvm.DiscontinuityDTO.ReasonForAbsenteeism == "OnMedicalLeave") //Özürlü devamsızlık
                    {
                        absenteeism.Description = $"{student.Firstname} İsimli öğrenci {absenteeism.StartingDate.ToShortDateString()} - {absenteeism.EndingDate.ToShortDateString()} tarihleri arasında raporludur.";
                        absenteeism.AbsencesStatus = ENTITIES.Enums.AbsencesStatus.Excused;
                    }
                    else if (dvm.DiscontinuityDTO.ReasonForAbsenteeism == "UnexcusedAbsences")
                    {
                        absenteeism.Description = $"{student.Firstname} İsimli öğrenci {absenteeism.StartingDate.ToShortDateString()} - {absenteeism.EndingDate.ToShortDateString()} tarihleri arasında okula gelmemiştir.";
                        absenteeism.AbsencesStatus = ENTITIES.Enums.AbsencesStatus.Unexcused;
                    }

                    absenteeism.DataEntryPerson = $"{(Session["teacher"] as Teacher).Firstname} {(Session["teacher"] as Teacher).Lastname} ";

                    absenteeism.StudentID = student.ID;
                    _absenteeismRep.Add(absenteeism);
                }
                else { TempData["WrongDate"] = "Girilen tarih hatalıdır. Lütfen tekrar deneyiniz."; return RedirectToAction("AddDiscontinuity"); }
            }
            else { TempData["WrongDate"] = "Girilen tarih hatalıdır. Lütfen tekrar deneyiniz."; return RedirectToAction("AddDiscontinuity"); }

            TempData["Successful"] = "Devamsızlık bilgisi sisteme başarılı bir şekilde kaydedildi.";
            return RedirectToAction("ListClassroom");
        }

        /// <summary>
        /// Seçili öğrencinin devamsızlık bilgisini günceller.
        /// </summary>
        /// <param name="id">Öğrenci ID</param>
        /// <returns></returns>
        public ActionResult UpdateDiscontinuity(int id)
        {
            Absenteeism absenteeism = _absenteeismRep.Find(id);

            DiscontinuityVM dvm = new DiscontinuityVM
            {
                Absenteeism = absenteeism,
                Student = _studentRep.Find(absenteeism.ID),

                DiscontinuityDTO = new ConsumeDTO.DiscontinuityDTO()
            };
            return View(dvm);
        }
        [HttpPost]
        public ActionResult UpdateDiscontinuity(DiscontinuityVM dvm)
        {
            if (dvm.DiscontinuityDTO.EndingDate < dvm.DiscontinuityDTO.StartingDate) { TempData["WrongDate"] = "Girilen tarih hatalıdır. Lütfen tekrar deneyiniz."; return RedirectToAction("UpdateDiscontinuity"); }

            Absenteeism updateAbsenteeism = _absenteeismRep.Find(dvm.Absenteeism.ID); //Güncellenecek devamsızlığın ID si üzerinden veriyi DB'de buluyoruz.

            updateAbsenteeism.StartingDate = Convert.ToDateTime(dvm.DiscontinuityDTO.StartingDate); //Yeni başlangıç tarihini atıyoruz.
            updateAbsenteeism.EndingDate = Convert.ToDateTime(dvm.DiscontinuityDTO.EndingDate); //Yeni bitiş tarihini atıyoruz.

            TimeSpan timeSpan = updateAbsenteeism.EndingDate - updateAbsenteeism.StartingDate;
            updateAbsenteeism.AbsencesCount = Convert.ToInt32(timeSpan.TotalDays) + 1; // Yeni devamsızlık gününü hesaplıyoruz.

            Student selectStudent = _studentRep.Find(dvm.Student.ID); //Öğrenci bilgileri için öğrenciyi buluyoruz.

            if (dvm.DiscontinuityDTO.ReasonForAbsenteeism == "SentryStudent") //Nöbetçi öğrenci seçildiyse;
            {
                updateAbsenteeism.Description = $"{selectStudent.Firstname} İsimli öğrenci {updateAbsenteeism.StartingDate.ToShortDateString()} - {updateAbsenteeism.EndingDate.ToShortDateString()} tarihleri arasında nöbetçidir.";
                updateAbsenteeism.AbsencesStatus = ENTITIES.Enums.AbsencesStatus.Excused;
            }
            else if (dvm.DiscontinuityDTO.ReasonForAbsenteeism == "OnMedicalLeave") //Özürlü devamsızlık
            {
                updateAbsenteeism.Description = $"{selectStudent.Firstname} İsimli öğrenci {updateAbsenteeism.StartingDate.ToShortDateString()} - {updateAbsenteeism.EndingDate.ToShortDateString()} tarihleri arasında raporludur.";
                updateAbsenteeism.AbsencesStatus = ENTITIES.Enums.AbsencesStatus.Excused;
            }
            else if (dvm.DiscontinuityDTO.ReasonForAbsenteeism == "UnexcusedAbsences")
            {
                updateAbsenteeism.Description = $"{selectStudent.Firstname} İsimli öğrenci {updateAbsenteeism.StartingDate.ToShortDateString()} - {updateAbsenteeism.EndingDate.ToShortDateString()} tarihleri arasında okula gelmemiştir.";
                updateAbsenteeism.AbsencesStatus = ENTITIES.Enums.AbsencesStatus.Unexcused;
            }

            //Yukarıda işaretli olan RB'a göre Açıklama kısmını güncelliyoruz.

            _absenteeismRep.Update(updateAbsenteeism);

            TempData["Successful"] = "Devamsızlık bilgisi başarılı bir şekilde güncellendi.";
            return RedirectToAction("ListClassroom");
        }

        /// <summary>
        /// Seçili devamsızlık verisini DB üzerinde 'Delete' statüsüne çeker.
        /// </summary>
        /// <param name="id">Devamsızlık ID</param>
        /// <returns></returns>
        public ActionResult DeleteDiscontinuity(int id)
        {
            _absenteeismRep.Delete(_absenteeismRep.Find(id));

            return RedirectToAction("ListClassroom");
        }
    }
}