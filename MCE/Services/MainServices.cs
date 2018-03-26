using MCE.Data;
using MCE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCE.Services
{
    public class MainServices
    {
        private readonly DbContext _db;

        public CustomUser GetUser(string email)
        {
            var user = _db.Users.Where(x => x.UserName == email && x.status == 1);
            if (user != null)
            {
                return user.First();
            }
            else
            {
                return null;
            }
        }
    }
}