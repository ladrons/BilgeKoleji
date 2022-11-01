using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.COMMON.Tools;
using Project.ENTITIES.Models;
using Project.WebUI.Tools.Authentication;
using Project.WebUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.WebUI.Areas.StudentArea.Controllers
{
    [StudentAuth]
    public class StudentHomeController : Controller
    {
        HomeworkRepository _homeworkRep; ExamGradeRepository _examGradeRep; SemesterRepository _semesterRep;

        public StudentHomeController()
        {
            _homeworkRep = new HomeworkRepository();
            _examGradeRep = new ExamGradeRepository();
            _semesterRep = new SemesterRepository();
        }

        /// <summary>
        /// Genel öğrenci işlemlerinin bulunduğu action
        /// </summary>
        /// <returns></returns>
        public ActionResult StudentProcessing()
        {
            Student student = (Session["student"] as Student);

            StudentVM svm = new StudentVM
            {
                Student = student

            };

            return View(svm);
        }

        /// <summary>
        /// Seçili öğrencinin devamsızlık bilgilerini gösterir.
        /// </summary>
        /// <param name="id">Öğrenci ID</param>
        /// <returns></returns>
        public ActionResult ShowDiscontinuity()
        {
            Student findStudent = (Session["student"] as Student);

            StudentVM svm = new StudentVM
            {
                Student = findStudent,
                Absenteeisms = findStudent.Absenteeisms
            };

            return View(svm);
        }

        /// <summary>
        /// Seçili öğrencinin sınav notlarını gösterir.
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowExamGrade()
        {
            StudentVM svm = new StudentVM();

            svm.Student = Session["student"] as Student;
            svm.Semester = _semesterRep.GetLastData();
            svm.ExamGrades = _examGradeRep.Where(x => x.StudentID == svm.Student.ID && x.SemesterID == svm.Semester.ID).ToList();

            return View(svm);
        }



        public ActionResult AddHomework()
        {
            StudentVM svm = new StudentVM
            {
                Student = (Session["student"] as Student)
            };

            return View(svm);
        }
        [HttpPost]
        public ActionResult AddHomework(HttpPostedFileBase homework)
        {
            Homework newHomework = new Homework();

            newHomework.TermPaper = FileUploader.UploadFile("/Tools/Homework/", homework);

            if (homework == null)
            {
                TempData["MissingFile"] = "Lütfen bir dosya seçiniz.";
                return View("AddHomework");
            }
            if (newHomework.TermPaper == "2")
            {
                TempData["WrongFile"] = "Girdiğiniz dosya desteklenmemektedir.";
                return View("AddHomework");
            }

            newHomework.HomeworkName = homework.FileName;
            newHomework.StudentID = (Session["student"] as Student).ID;

            _homeworkRep.Add(newHomework);

            TempData["Successful"] = "Ödev başarılı bir şekilde sisteme kaydedildi.";

            return View("AddHomework");
        }
    }
}