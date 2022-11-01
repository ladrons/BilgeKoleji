using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO.WinUI
{
    public class TeacherDTO:BaseEntityDTO
    {
        public string Name { get; set; } // Öğretmen isim soyisim
        public string BranchName { get; set; } // Öğretmenin kayıtlı olduğu branşın adı
        public string LessonName { get; set; } // Öğretmene atanan ders adı
    }
}
