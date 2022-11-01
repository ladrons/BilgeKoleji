using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.COMMON.Tools;
using Project.ENTITIES.Models;
using Project.WebUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.WebUI.Controllers
{
    public class HomeController : Controller
    {
        TeacherRepository _teacherRep; ParentRepository _parentRep; StudentRepository _studentRep; AnnouncementRepository _announcementRep;

        public HomeController()
        {
            _teacherRep = new TeacherRepository();
            _parentRep = new ParentRepository();
            _studentRep = new StudentRepository();
            _announcementRep = new AnnouncementRepository();
        }

        public ActionResult HomePage()
        {
            AnnouncementVM avm = new AnnouncementVM
            {
                Announcements = _announcementRep.GetActives(),
            };

            return View(avm);
        }

        //--||--\\ //--||--\\ //--||--\\

        #region TeacherLogin GET and POST
        /// <summary>
        /// Öğretmen login işlemlerini yapar.
        /// </summary>
        /// <returns></returns>
        public ActionResult TeacherLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TeacherLogin(Teacher teacher)
        {
            Teacher findTeacher = _teacherRep.FirstOrDefault(x => x.UserName == teacher.UserName);

            if (findTeacher == null)
            {
                ViewBag.noTeacherFound = "Geçersiz Kullanıcı Adı veya Şifre";
                return View();
            }

            string deCrypted = MyCrypt.DeCrypt(findTeacher.Password);

            if (teacher.Password == deCrypted && findTeacher.Role == ENTITIES.Enums.UserRole.Teacher)
            {
                Session["teacher"] = findTeacher;

                return RedirectToAction("ListClassroom", "Discontinuity", new { area = "TeacherArea" });
            }

            ViewBag.noTeacherFound = "Geçersiz Kullanıcı Adı veya Şifre";
            return View();
        }
        #endregion

        #region ParentLogin GET and POST
        /// <summary>
        /// Veli giriş işlemlerini gerçekleştirir.
        /// </summary>
        /// <returns></returns>
        public ActionResult ParentLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ParentLogin(Parent parent)
        {
            Parent findParent = _parentRep.FirstOrDefault(x => x.UserName == parent.UserName);

            if (findParent == null)
            {
                ViewBag.noParentFound = "Geçersiz Kullanıcı Adı veya Şifre";
                return View();
            }

            string deCrypted = MyCrypt.DeCrypt(findParent.Password);

            if (parent.Password == deCrypted && findParent.Role == ENTITIES.Enums.UserRole.Parent)
            {
                Session["parent"] = findParent;

                return RedirectToAction("ParentProcess", "ParentHome", new { area = "ParentArea" });
            }
            ViewBag.noParentFound = "Geçersiz Kullanıcı Adı veya Şifre";
            return View();
        }
        #endregion

        #region StudentLogin GET and POST
        /// <summary>
        /// Öğrenci login işlemlerini gerçekleştirir.
        /// </summary>
        /// <returns></returns>
        public ActionResult StudentLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudentLogin(Student student)
        {
            Student findStudent = _studentRep.FirstOrDefault(x => x.SchoolNumber == student.SchoolNumber);

            if (findStudent == null)
            {
                ViewBag.noStudentFound = "Geçersiz Okul Numarası veya Şifre";
                return View();
            }

            string deCrypted = MyCrypt.DeCrypt(findStudent.Password);

            if (student.Password == deCrypted && findStudent.Role == ENTITIES.Enums.UserRole.Student)
            {
                Session["student"] = findStudent;

                return RedirectToAction("StudentProcessing", "StudentHome", new { area = "StudentArea" });
            }
            ViewBag.noStudentFound = "Geçersiz Okul Numarası veya Şifre";
            return View();
        }
        #endregion

        //--||--\\ //--||--\\ //--||--\\

        public ActionResult LogOut()
        {
            if (Session["teacher"] != null) Session["teacher"] = null;
            else if (Session["parent"] != null) Session["parent"] = null;
            else if (Session["student"] != null) Session["student"] = null;

            TempData["confirmLogOut"] = "Başarılı bir şekilde çıkış yapıldı.";
            return RedirectToAction("HomePage");
        }
    }
}