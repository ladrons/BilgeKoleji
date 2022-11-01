using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO.WinUI
{
    public class ListSubLessonDTO:BaseEntityDTO
    {
        public string SubLessonName { get; set; }
        public string SubLessonCode { get; set; }
        public DateTime SubLessonCreatedDate { get; set; }
        public DateTime? SubLessonUpdateDate { get; set; }
        public string LessonName { get; set; }
    }
}
