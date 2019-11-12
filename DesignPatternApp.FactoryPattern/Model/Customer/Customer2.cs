using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.FactoryPattern.Model.Customer
{
    public  class Customer2 : ICustomer
    {
        public string Name { get; set; }
        public void Report()
        {
            this.Name = "radman.co";
            Console.WriteLine("This is legal person!");
            Console.WriteLine($"name is : {Name}");
        }
    }
}
