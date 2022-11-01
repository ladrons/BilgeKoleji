using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ExamGrade : BaseEntity
    {
        public string LessonName { get; set; } //Sınav notunun ait olduğu ders adı
        public int? FirstResult { get; set; } //1.Sınav notu
        public int? SecondResult { get; set; } //2.Sınav notu
        public int? ThirdResult { get; set; } //3.Sınav notu (Zorunlu değil)
        public int? LessonAverage { get; set; } // Girilen dersin ortalaması

        public int StudentID { get; set; }
        public int SemesterID { get; set; }



        //Relational Properties

        public virtual Student Student { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
