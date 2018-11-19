using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace BasicAuthAPI.Models
{
    public class UserManager
    {
        private BasicAuthDemoEntities _Context;

        public UserManager()
        {
            _Context = new BasicAuthDemoEntities();
        }

        public bool ValidateUser(string UserName, string Password)
        {
            var result = _Context.UserMasters.SingleOrDefault(x => x.UserName.Equals(UserName, StringComparison.OrdinalIgnoreCase) && x.Password == Password);
            return result != null ? true : false;
        }
    }
}