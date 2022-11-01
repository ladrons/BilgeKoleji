using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO.WinUI
{
    public class StudentDTO
    {
        public string SchoolNumber { get; set; } // Okul numarası
        public string StudentName { get; set; } // Öğrenci isim soyisim
        public string Class { get; set; } // Sınıf
        public string Branch { get; set; } // Şube
        public string Gender { get; set; } // Cinsiyet
    }
}
