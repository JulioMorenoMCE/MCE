using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MCE.Models
{
    public class tblInventory
    {
        [Key]
        [Index]
        public int id { get; set; }
        public string name { get; set; }
        public string asset { get; set; }
        public string username { get; set; }
        public string tight { get; set; }
        public string description { get; set; }
        public bool status { get; set; }
    }
}