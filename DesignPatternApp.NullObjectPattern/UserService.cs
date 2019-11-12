using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.NullObjectPattern.Model;

namespace DesignPatternApp.NullObjectPattern
{
   public  class UserService
    {
        public User GetUser(string name)
        {
            if (name == "maryam")
            {
                return  new User() { Authenticated = true , UserName = "maryam"};
            }

            if (name == "zahra")
            {
                return new User() {Authenticated = false, UserName = "zahra"};
            }


            return new NullUser();
        }
    }
}
