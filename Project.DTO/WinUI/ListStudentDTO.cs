using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO.WinUI
{
    public class ListStudentDTO
    {
        // Bu DTO OgrenciIslemleri'ndeki DataGridView için yaratılmıştır.
        // Bu DTO MezuniyetIslemleri'ndeki DataGridView için yaratılmıştır.

        public string StudentNumber { get; set; } //Okul numarası
        public string StudentClass { get; set; } //Sınıf
        public string StudentBranch { get; set; } //Şube
        public string StudentFirstname { get; set; } //İsim
        public string StudentLastname { get; set; } //Soyisim
        public string Gender { get; set; } //Cinsiyet
    }
}
