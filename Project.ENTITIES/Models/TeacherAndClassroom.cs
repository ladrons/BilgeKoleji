using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class TeacherAndClassroom:BaseEntity
    {
        public int TeacherID { get; set; }
        public int ClassroomID { get; set; }

        //Relational Properties

        public virtual Teacher Teacher { get; set; }
        public virtual Classroom Classroom { get; set; }
    }
}
