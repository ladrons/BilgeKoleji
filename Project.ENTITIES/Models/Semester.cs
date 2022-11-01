using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Semester : BaseEntity
    {
        public string SemesterName { get; set; } // Dönemin adı (2022 - 23 Bahar Dönemi gibi)
        public DateTime StartingDate { get; set; } // Dönemin başlangıç tarihi
        public DateTime EndingDate { get; set; } // Dönemin bitiş tarihi
        public SemesterStatus SemesterStatus { get; set; }

        //Relational Properties

        public virtual List<ExamGrade> ExamGrades { get; set; }
        public virtual List<Document> Documents { get; set; }
    }
}