﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<StudentViewModel> students{ get; set; }
    }
}
