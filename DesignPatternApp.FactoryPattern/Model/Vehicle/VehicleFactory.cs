namespace DesignPatternApp.FactoryPattern.Model.Vehicle
{
    public  abstract class VehicleFactory
    {
        public  abstract  IVehicle GetVehicle<T>() where  T : class ;
    }
}
