using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.FactoryPattern.Model.Customer
{
    public class Customer1 : ICustomer
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public void Report()
        {
            this.FirstName = "fatemeh";
            this.LastName = "montazeri";
            Console.WriteLine("This is real person!");
            Console.WriteLine($"name:{FirstName} {LastName}");
            
        }
    }
}
