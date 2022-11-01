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
    public class ExamGradeController : Controller
    {
        ClassroomRepository _classroomRep; ExamGradeRepository _examGradeRep; StudentRepository _studentRep;
        SemesterRepository _semesterRep;

        TeacherAndClassroomRepository _teacherAndClassroomRep;

        public ExamGradeController()
        {
            _classroomRep = new ClassroomRepository();
            _examGradeRep = new ExamGradeRepository();
            _studentRep = new StudentRepository();
            _semesterRep = new SemesterRepository();

            _teacherAndClassroomRep = new TeacherAndClassroomRepository();
        }

        //--\\ //--\\ //--\\ //--\\

        /// <summary>
        /// Öğretmenin dersine girdiği sınıfları listeler.
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
        /// Seçili sınıftaki öğrencileri listeler.
        /// </summary>
        /// <param name="id">Classroom ID</param>
        /// <returns></returns>
        public ActionResult ListStudentInClassroom(int id)
        {
            ClassroomVM cvm = new ClassroomVM();

            cvm.Classroom = _classroomRep.Find(id);
            cvm.Semester = _semesterRep.GetLastData();

            int semesterId = _semesterRep.GetLastData().ID;
            Teacher teacher = (Session["teacher"] as Teacher);

            cvm.ExamGrades = _examGradeRep.Where(x => x.SemesterID == semesterId && x.LessonName == teacher.Lesson.LessonName && x.Status != ENTITIES.Enums.DataStatus.Deleted).ToList();

            return View(cvm);

            //ToDo: Bu kısımda front-end tarafında list oluşturuyorum. Yanlış bir kullanım. Proje tesliminden sonra bu kısımda değişiklik yapılmak zorunda. (08/08)
        }

        /// <summary>
        /// Seçili olan öğrencinin sınav notlarını listeler.
        /// </summary>
        /// <param name="id">Öğrenci ID</param>
        /// <returns></returns>
        public ActionResult ListStudentExamGrade(int id)
        {
            Teacher teacher = (Session["teacher"] as Teacher);

            ExamGradeVM egvm = new ExamGradeVM
            {
                Teacher = teacher,
                Student = _studentRep.Find(id),

                ExamGrades = _examGradeRep.Where(x => x.StudentID == id && x.LessonName == teacher.Lesson.LessonName && x.Status != ENTITIES.Enums.DataStatus.Deleted).ToList()
            };

            return View(egvm);
        }

        //--\\ //--\\ //--\\ //--\\

        /// <summary>
        /// Seçilmiş olan öğrenciye not girişi ekler.
        /// </summary>
        /// <param name="id">Öğrenci ID</param>
        /// <returns></returns>
        public ActionResult AddExamGrade(int id)
        {
            ExamGradeVM egvm = new ExamGradeVM();

            egvm.Teacher = (Session["teacher"] as Teacher); //Öğretmen Session'dan geliyor.

            egvm.Student = _studentRep.Find(id); //Öğrenciyi bulduk.
            egvm.ExamGrade = _examGradeRep.Where(x => x.StudentID == id && x.LessonName == egvm.Teacher.Lesson.LessonName && x.Status != ENTITIES.Enums.DataStatus.Deleted).FirstOrDefault();

            if(egvm.ExamGrade == null)
            {
                egvm.ExamGrade = new ExamGrade();
            }

            return View(egvm);
        }
        [HttpPost]
        public ActionResult AddExamGrade(ExamGradeVM egvm)
        {
            ExamGrade examGrade = new ExamGrade();

            if (egvm.ExamGrade.FirstResult >= 0 && egvm.ExamGrade.FirstResult <= 100)
            {
                examGrade.LessonName = (Session["teacher"] as Teacher).Lesson.LessonName;

                examGrade.FirstResult = egvm.ExamGrade.FirstResult;
            }
            else
            {
                TempData["WrongResult"] = "Girilen not hatalıdır. Lütfen tekrar deneyiniz.";
                return RedirectToAction("AddExamGrade");
            }
            examGrade.StudentID = egvm.Student.ID;
            examGrade.SemesterID = _semesterRep.GetLastData().ID;

            _examGradeRep.Add(examGrade);

            TempData["Successful"] = "Not girişi başarılı bir şekilde sisteme kaydedilmiştir.";

            return RedirectToAction("ListClassroom");
        }

        /// <summary>
        /// Seçili olan ders notunu günceller.
        /// </summary>
        /// <param name="egvm">ExamGrade ID</param>
        /// <returns></returns>
        public ActionResult UpdateExamGrade(int id)
        {
            ExamGrade examGrade = _examGradeRep.Find(id); //DB'den güncellenek veriyi buluyoruz.

            ExamGradeVM egvm = new ExamGradeVM
            {
                ExamGrade = examGrade,
                Student = _studentRep.Find(examGrade.StudentID)
            };

            return View(egvm);
        }
        [HttpPost]
        public ActionResult UpdateExamGrade(ExamGradeVM egvm)
        {
            ExamGrade updateExamGrade = _examGradeRep.Find(egvm.ExamGrade.ID);

            if (egvm.ExamGrade.FirstResult != null) //Gelen değerin 1.sınav notu null değil ise;
            {
                if(egvm.ExamGrade.FirstResult > 0 && egvm.ExamGrade.FirstResult < 100)
                {
                    if (egvm.ExamGrade.FirstResult != updateExamGrade.FirstResult) //Eğer 1.sınav notu DB'de kayıtlı olan sınav notundan farklı ise;
                    {
                        updateExamGrade.FirstResult = egvm.ExamGrade.FirstResult; //Yeni sınav notunu değişkene ata.
                    }
                }
                else { TempData["WrongValue"] = "Girilen not gerçeli bir değerde değildir."; return RedirectToAction("UpdateExamGrade"); }
            }

            if(egvm.ExamGrade.SecondResult != null) //2.Sınav
            {
                if(egvm.ExamGrade.SecondResult > 0 && egvm.ExamGrade.SecondResult < 100)
                {
                    if (egvm.ExamGrade.SecondResult != updateExamGrade.SecondResult)
                    {
                        updateExamGrade.SecondResult = egvm.ExamGrade.SecondResult;
                    }
                }
                else { TempData["WrongValue"] = "Girilen not gerçeli bir değerde değildir."; return RedirectToAction("UpdateExamGrade"); }
                
            }

            if (egvm.ExamGrade.ThirdResult != null) //3.Sınav
            {
                if(egvm.ExamGrade.ThirdResult > 0 && egvm.ExamGrade.ThirdResult < 100)
                {
                    if (egvm.ExamGrade.ThirdResult != updateExamGrade.ThirdResult)
                    {
                        updateExamGrade.ThirdResult = egvm.ExamGrade.ThirdResult;
                    }
                }
                else { TempData["WrongValue"] = "Girilen not gerçeli bir değerde değildir."; return RedirectToAction("UpdateExamGrade"); }
                
            }

            _examGradeRep.Update(updateExamGrade);

            TempData["Successful"] = "Not girişi başarılı bir şekilde sisteme kaydedilmiştir.";

            return RedirectToAction("ListClassroom");
        }
    }
}