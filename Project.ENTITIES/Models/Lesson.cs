using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Lesson : BaseEntity
    {
        public string LessonName { get; set; } // Ders adı

        //Relational Properties

        public virtual List<LessonInClassroom> LessonInClassrooms { get; set; }
        public virtual List<SubLesson> SubLessons { get; set; }
        public virtual List<Teacher> Teachers { get; set; }

        public override string ToString()
        {
            return LessonName;
        }
    }
}
