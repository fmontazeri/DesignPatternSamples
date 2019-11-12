using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.FactoryPattern.Model;

namespace DesignPatternApp.FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Vehicle

                Console.WriteLine("//------------Vehicle ----------//");
                var factory = new ConcreteVehicleFactory();

                var bike = factory.GetVehicle<Bike>();
                bike.Name = "Honda";
                Console.WriteLine($"An instance of Bike create! : {(bike.Name)}");

                var scooter = factory.GetVehicle<Scooter>();
                scooter.Name = "Scooter One";
                Console.WriteLine($"An instance of Scooter  create ! : {(scooter.Name)}");
                Console.WriteLine("Some instances create successfully !");

              
            #endregion

            #region [Customer]
            Console.WriteLine("//------------Customer ----------//");
            CustomerFactory.GetCustomerType(1).Report();
            CustomerFactory.GetCustomerType(2).Report();
 
          #endregion

          Console.ReadLine();

        }
    }
}
