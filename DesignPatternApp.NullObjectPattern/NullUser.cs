using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.NullObjectPattern.Model;

namespace DesignPatternApp.NullObjectPattern
{
   public  class NullUser : User
    {
        public NullUser()
        {
            Authenticated = false;
        }
    }
}
