using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Document:BaseEntity
    {
        public bool CertificateOfAppreciation { get; set; } // Takdir belgesi.
        public bool CertificateOfParticipation { get; set; } // Teşekkür belgesi.

        public int StudentID { get; set; }
        public int SemesterID { get; set; }

        //Relational Properties

        public virtual Student Student { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
