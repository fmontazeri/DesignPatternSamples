namespace DesignPatternApp.FactoryPattern.Model.Vehicle
{
    public interface IVehicle
    {
        string  Name { get; set; }
        void Drive();
    }
}
