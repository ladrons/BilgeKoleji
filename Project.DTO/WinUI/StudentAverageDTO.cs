using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO.WinUI
{
    public class StudentAverageDTO
    {
        public int YearID { get; set; }
        public int StudentID { get; set; }

        public int? AutumnAverage { get; set; }
        public int? SpringAverage { get; set; }
        public int? YearAverage { get; set; }

    }
}
