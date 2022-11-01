using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebUI.VMClasses
{
    public class ParentVM
    {
        public Parent Parent { get; set; }

        public ExamGrade ExamGrade { get; set; }
        public List<ExamGrade> ExamGrades { get; set; }

        public Absenteeism Absenteeism { get; set; }
        public List<Absenteeism> Absenteeisms { get; set; }

        public Student Student { get; set; }
        public List<Student> Students { get; set; }
    }
}