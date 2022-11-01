using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebUI.Areas.TeacherArea.Data.TeacherVMClasses
{
    public class ExamGradeVM
    {
        public ExamGrade ExamGrade { get; set; }
        public List<ExamGrade> ExamGrades { get; set; }

        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
    }
}