using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Facade.Model
{
   public  class User
    {
        public User()
        {
            
        }

        public User(int id , string name , int phoneNumber)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public  int PhoneNumber { get; set; }
    }
}
