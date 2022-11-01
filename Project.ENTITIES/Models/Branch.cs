using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Branch : BaseEntity // Çalışma alanı = Branş
    {
        public string StudyName { get; set; } // Branş ismi
        public string Description { get; set; } // Branş açıklaması

        //Relational Properties

        public virtual List<Teacher> Teachers { get; set; }

        public override string ToString()
        {
            return $"{StudyName}";
        }
    }
}