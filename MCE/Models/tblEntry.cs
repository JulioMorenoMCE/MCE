﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MCE.Models
{
    public class tblEntry
    {
        [Key]
        [Index]
        public int id { get; set; }
        public string name { get; set; }
        public bool status { get; set; }
    }
}