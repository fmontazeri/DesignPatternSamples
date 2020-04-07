using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.Prototype.Models;

namespace DesignPatternApp.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            var fatemeh = new Person("fatemeh", "montazeri", "maryam",10);
            var copyFatemeh = new Person
            {
                FirstName = fatemeh.FirstName, LastName = fatemeh.LastName, Age = fatemeh.Age
            };
            //Problem :
            //We aren't able to set NickName of person because of It's private property.And sth like this specially in complex object

            //Solution: Implement Prototype pattern
            var copyObj = fatemeh.Clone();


        }
    }
}
