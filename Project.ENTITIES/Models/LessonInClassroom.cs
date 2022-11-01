using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class LessonInClassroom : BaseEntity
    {
        public int LessonID { get; set; }
        public int ClassroomID { get; set; }

        //Relational Properties

        public virtual Lesson Lesson { get; set; }
        public virtual Classroom Classroom { get; set; }

        public override string ToString()
        {
            return $"{ Lesson.LessonName}";
        }
    }
}
