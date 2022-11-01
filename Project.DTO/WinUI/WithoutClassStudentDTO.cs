using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO.WinUI
{
    public class WithoutClassStudentDTO:BaseEntityDTO
    {
        public string SchoolNumber { get; set; }
        public string StudentName { get; set; }
        public decimal GradeAverage { get; set; }
    }
}
