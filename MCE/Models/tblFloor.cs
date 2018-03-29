using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MCE.Models
{
    public class tblFloor
    {
        [Key]
        [Index]
        public int id { get; set; }
        public string Job { get; set; }
        public string Technician { get; set; }
        public string Stage { get; set; }
        public string Status { get; set; }
        public string CAT { get; set; }
        public string ST { get; set; }
        public string TTC { get; set; }
        public string description { get; set; }
        public bool status { get; set; }
    }
}