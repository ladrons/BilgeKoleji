using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Announcement:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Writer { get; set; }

        public int TeacherID { get; set; }

        //Relational Properties

        public virtual List<Teacher> Teachers { get; set; }
    }
}
