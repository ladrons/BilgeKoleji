using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO.WinUI
{
    public class ListClassroomDTO
    {
        public string Class { get; set; } // Sınıf numarası
        public string Branch { get; set; } // Şube adı / kodu

        public override string ToString()
        {
            return Branch;
        }
    }
}
