using System;

namespace DesignPatternApp.FactoryPattern.Model.Vehicle
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
