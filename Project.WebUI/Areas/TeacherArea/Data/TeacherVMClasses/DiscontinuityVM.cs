using Project.ENTITIES.Models;
using Project.WebUI.ConsumeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebUI.Areas.TeacherArea.Data.TeacherVMClasses
{
    public class DiscontinuityVM
    {
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }

        public Absenteeism Absenteeism { get; set; }
        public List<Absenteeism> Absenteeisms { get; set; }

        public DiscontinuityDTO DiscontinuityDTO { get; set; }
    }
}