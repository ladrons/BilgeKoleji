using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebUI.VMClasses
{
    public class AnnouncementVM
    {
        public Teacher Teacher { get; set; }

        public Announcement Announcement { get; set; }
        public List<Announcement> Announcements { get; set; }
    }
}