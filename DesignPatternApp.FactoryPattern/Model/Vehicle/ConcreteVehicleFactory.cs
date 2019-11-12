using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.FactoryPattern.Model;
using DesignPatternApp.FactoryPattern;

namespace DesignPatternApp.FactoryPattern
{
   public  class ConcreteVehicleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle<T>()
        {
            if (typeof(T) == typeof(Scooter))
                return new Scooter();

            if (typeof(T) == typeof(Bike))
                return new Bike();

            Console.WriteLine("an error has been Occurred!");
            return null;
        }
    }
}
