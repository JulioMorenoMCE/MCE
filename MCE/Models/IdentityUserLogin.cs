using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MCE.Models
{
    public class AspNetUserLogins
    {
        [Key]
        public string UserId { get; set; }
        public string ProviderKey { get; set; }
        public string LoginProvider { get; set; }
    }
}