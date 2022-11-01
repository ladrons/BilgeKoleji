using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class TeacherSyllabus:BaseEntity
    {
        //ToDo: Buralara daha güzel bir isim verilebilir. (Düşük Öncelik)

        public string LessonName { get; set; }
        public string Day { get; set; }
        public string ClassOne { get; set; }
        public string ClassTwo { get; set; }
        public string ClassThree { get; set; }
        public string ClassFour { get; set; }
        public string ClassFive { get; set; }
        public string ClassSix { get; set; }
        public string ClassSeven { get; set; }
        public string ClassEight { get; set; }

        public int TeacherID { get; set; }

        //Relational Properties

        public virtual Teacher Teacher { get; set; }

    }
}
