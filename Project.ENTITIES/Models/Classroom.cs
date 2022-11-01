using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Classroom : BaseEntity
    {
        public string Class { get; set; } // Sınıf adı/numarası
        public string Section { get; set; } // Şube kodu


        //Relational Properties

        public virtual List<LessonInClassroom> LessonInClassrooms { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<TeacherAndClassroom> TeachersAndClassrooms { get; set; }

        public override string ToString()
        {
            return $"{Class} - {Section}";
        }
    }
}
