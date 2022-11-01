using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.WebUI.Tools.Authentication;
using Project.WebUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.WebUI.Areas.TeacherArea.Controllers
{
    [TeacherAuth]
    public class AnnouncementController : Controller
    {
        AnnouncementRepository _announcementRep; TeacherRepository _teacherRep;
        public AnnouncementController()
        {
            _announcementRep = new AnnouncementRepository();
            _teacherRep = new TeacherRepository();
        }

        /// <summary>
        /// Kayıtlı olan bütün aktif duyuruları listeler.
        /// </summary>
        /// <returns></returns>
        public ActionResult ListActiveAnnouncement()
        {
            AnnouncementVM avm = new AnnouncementVM
            {
                Announcements = _announcementRep.GetActives(),

                Teacher = (Session["teacher"] as Teacher)
            };

            return View(avm);
        }

        //--\\ //--\\ //--\\

        /// <summary>
        /// Öğretmenin sisteme yeni duyuru kaydetmesini sağlar.
        /// </summary>
        /// <returns></returns>
        public ActionResult AddAnnouncement()
        {
            AnnouncementVM avm = new AnnouncementVM
            {
                Teacher = (Session["teacher"] as Teacher)
            };
            
            return View(avm);
        }
        [HttpPost]
        public ActionResult AddAnnouncement(Announcement announcement)
        {
            announcement.Writer = $"{(Session["teacher"] as Teacher).Firstname} {(Session["teacher"] as Teacher).Lastname}";

            _announcementRep.Add(announcement);

            TempData["Successful"] = "Duyuru başarılı bir şekilde kaydedildi.";

            return RedirectToAction("ListActiveAnnouncement");
        }
    }
}