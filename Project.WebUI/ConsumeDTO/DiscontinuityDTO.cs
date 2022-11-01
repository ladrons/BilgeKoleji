using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebUI.ConsumeDTO
{
    public class DiscontinuityDTO
    {
        public DateTime? StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }

        public string ReasonForAbsenteeism { get; set; } //Devamsızlık durumu.
    }
}