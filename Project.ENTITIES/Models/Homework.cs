using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Homework:BaseEntity
    {
        public Homework()
        {
            UploadDate = DateTime.Now;
        }

        public string HomeworkName { get; set; }
        public string TermPaper { get; set; }
        public DateTime UploadDate { get; set; }

        public int StudentID { get; set; }

        //Relational Properties

        public virtual Student Student { get; set; }
    }
}
