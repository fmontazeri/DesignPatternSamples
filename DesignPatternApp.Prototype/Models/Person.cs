using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Prototype.Models
{
    public class Person : 
              //IPrototype<Person>
              AggregateRoot<Person>
    {
        public Person()
        {
        }


        public Person(string firstName, string lastName, string nickName , int age)
        {
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  int Age { get; set; }
        private  string NickName { get; set; }


        //public Person Clone()
        //{
        //    return this;
        //}

        public override Person Clone()
        {
            return this;
        }
    }
}
