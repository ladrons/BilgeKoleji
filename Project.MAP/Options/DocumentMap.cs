using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class DocumentMap : BaseMap<Document>
    {
        public DocumentMap()
        {
            Ignore(x => x.ID);

            HasKey(x => new
            {
                x.SemesterID,
                x.StudentID
            });
        }
    }
}
