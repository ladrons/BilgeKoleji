﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebUI.VMClasses
{
    public class TeacherVM
    {
        public Teacher Teacher { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}