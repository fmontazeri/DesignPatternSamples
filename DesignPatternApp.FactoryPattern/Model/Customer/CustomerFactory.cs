namespace DesignPatternApp.FactoryPattern.Model.Customer
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
