using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.FactoryPattern.Model;
using DesignPatternApp.FactoryPattern.Model.Car;
using DesignPatternApp.FactoryPattern.Model.Customer;
using DesignPatternApp.FactoryPattern.Model.Vehicle;

namespace DesignPatternApp.FactoryPattern
{
    public enum CarClass
    {
        Toyota,
        Benz
    }
    class Program
    {
        static void Main(string[] args)
        {

            #region Vehicle

                //Console.WriteLine("//------------Vehicle ----------//");
                //var factory = new ConcreteVehicleFactory();

                //var bike = factory.GetVehicle<Bike>();
                //bike.Name = "Honda";
                //Console.WriteLine($"An instance of Bike create! : {(bike.Name)}");

                //var scooter = factory.GetVehicle<Scooter>();
                //scooter.Name = "Scooter One";
                //Console.WriteLine($"An instance of Scooter  create ! : {(scooter.Name)}");
                //Console.WriteLine("Some instances create successfully !");

              
            #endregion

            #region [Customer]

            //Console.WriteLine("//------------Customer ----------//");
            //CustomerFactory.GetCustomerType(1).Report();
            //CustomerFactory.GetCustomerType(2).Report();

            #endregion

            #region [Car]

            Console.WriteLine("Choose one of these : Toyota or Benz");
            Console.WriteLine("Write Model:");
            var name = Console.ReadLine();
            Enum.TryParse(name, out CarClass carClass);
            ICarFactory carFactory = LoadCarFactory(carClass);
            var car = carFactory.Create(name);
            Console.WriteLine($"You choose : {car.Name}");
            Console.WriteLine($"{car.Name} is instantiate!");
            #endregion

            Console.ReadLine();

        }

        private static ICarFactory LoadCarFactory(CarClass car)
        { 
           
            switch (car)
            {
                case CarClass.Toyota:
                    return  new ToyotaFactory();
                case CarClass.Benz:
                    return  new BenzFactory();
                default:
                    return  new ToyotaFactory();
            }
        }
    }
}
