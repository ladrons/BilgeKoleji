using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO.API
{
    /// <summary>
    /// Öğretmenlerin ders programlarını diğer yetkililer ile (Müfettiş vb) paylaşılması için yaratılan bir DTO sınıfıdır.
    /// </summary>
    public class TeacherSyllabusDTO
    {
        public string TeacherName { get; set; } //Ders programının hangi öğretmene ait olduğunu göstermek için.
        public string LessonName { get; set; } //Öğretmenin verdiği dersin adı.
        public string Day { get; set; } //Ders programının ait olduğu gün.
        public string ClassOne { get; set; }
        public string ClassTwo { get; set; }
        public string ClassThree { get; set; }
        public string ClassFour { get; set; }
        public string ClassFive { get; set; }
        public string ClassSix { get; set; }
        public string ClassSeven { get; set; }
        public string ClassEight { get; set; }
    }
}
