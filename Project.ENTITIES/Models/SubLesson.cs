using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class SubLesson : BaseEntity
    {
        public string SubLessonName { get; set; } // Alt ders adı
        public string SubLessonCode { get; set; } // Alt ders adının kodlanmış hali. (Biyolojinin alt dersleri => BIY.1 - BIY.2 gibi)


        public int LessonID { get; set; }

        //Relational Properties

        public virtual Lesson Lesson { get; set; }

        public override string ToString()
        {
            return $"{SubLessonName} - {SubLessonCode}";
        }
    }
}