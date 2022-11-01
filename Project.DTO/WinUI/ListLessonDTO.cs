using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO.WinUI
{
    public class ListLessonDTO:BaseEntityDTO
    {
        public string LessonName { get; set; }
        public DateTime LessonCreatedDate { get; set; }
        public DateTime? LessonUpdateDate { get; set; }
    }
}
