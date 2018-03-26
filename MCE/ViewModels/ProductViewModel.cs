﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MCE.Models;

namespace MCE.ViewModels
{
    public class ProductViewModel
    {
        public tblProduct Product { get; set; }
        public IEnumerable<tblUnit> Units { get; set; }
        public string unit { get; set; }

    }
}