using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class LessonInClassroomMap : BaseMap<LessonInClassroom>
    {
        public LessonInClassroomMap()
        {
            Ignore(x => x.ID);

            HasKey(x => new
            {
                x.LessonID,
                x.ClassroomID
            });
        }
    }
}
