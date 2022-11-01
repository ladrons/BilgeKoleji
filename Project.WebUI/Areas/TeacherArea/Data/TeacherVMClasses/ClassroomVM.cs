using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebUI.Areas.TeacherArea.Data.TeacherVMClasses
{
    public class ClassroomVM
    {
        public Semester Semester { get; set; }

        public Classroom Classroom { get; set; }
        public List<Classroom> Classrooms { get; set; }

        public List<ExamGrade> ExamGrades { get; set; }
    }
}