using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Year : BaseEntity
    {
        public string YearName { get; set; }



        //Relational Properties

        public virtual List<StudentAverage> StudentAverages { get; set; }
    }
}
