using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.FactoryPattern.Model.Customer;

namespace DesignPatternApp.FactoryPattern
{
    public class CustomerFactory 
    {
       public static ICustomer GetCustomerType(int customerTypeId)
        {
            ICustomer customer;

            if(customerTypeId == 1)
                customer = new Customer1();
            else if(customerTypeId == 2)
                customer = new Customer2();
            else
                return null;

            return customer;
        }

    }
}
