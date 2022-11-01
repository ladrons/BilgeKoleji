using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.WebUI.Tools.Authentication;
using Project.WebUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.WebUI.Areas.ParentArea.Controllers
{
    [ParentAuth]
    public class ParentHomeController : Controller
    {
        ParentRepository _parentRep; StudentRepository _studentRep; AbsenteeismRepository _absenteeismRep; ExamGradeRepository _examGradeRep;

        public ParentHomeController()
        {
            _parentRep = new ParentRepository();
            _studentRep = new StudentRepository();
            _absenteeismRep = new AbsenteeismRepository();
            _examGradeRep = new ExamGradeRepository();
        }

        //--\\ //--\\ //--\\

        /// <summary>
        /// Genel veli işlemlerinin bulunduğu action
        /// </summary>
        /// <returns></returns>
        public ActionResult ParentProcess()
        {
            Parent parent = (Session["parent"] as Parent);

            ParentVM pvm = new ParentVM
            {
                Parent = parent,
                Students = parent.Students,
            };

            return View(pvm);
        }

        /// <summary>
        /// Seçili olan öğrencinin devamsızlık bilgilerini gösterir.
        /// </summary>
        /// <param name="id">Öğrenci ID</param>
        /// <returns></returns>
        public ActionResult ShowDiscontinuity(int id)
        {
            ParentVM pvm = new ParentVM();

            pvm.Parent = Session["parent"] as Parent;
            pvm.Student = _studentRep.Find(id);

            pvm.Absenteeisms = _absenteeismRep.Where(x => x.StudentID == pvm.Student.ID && x.Status != ENTITIES.Enums.DataStatus.Deleted).ToList();

            return View(pvm);
        }

        /// <summary>
        /// Seçili olan öğrencinin sınav sonuçlarını gösterir.
        /// </summary>
        /// <param name="id">Öğrenci ID</param>
        /// <returns></returns>
        public ActionResult ShowExamGrade(int id)
        {
            ParentVM pvm = new ParentVM();

            pvm.Parent = Session["parent"] as Parent;
            pvm.Student = _studentRep.Find(id);

            pvm.ExamGrades = _examGradeRep.Where(x => x.StudentID == pvm.Student.ID && x.Status != ENTITIES.Enums.DataStatus.Deleted).ToList();

            return View(pvm);
        }
    }
}