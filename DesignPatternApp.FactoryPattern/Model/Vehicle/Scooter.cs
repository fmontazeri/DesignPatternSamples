namespace DesignPatternApp.FactoryPattern.Model.Vehicle
{
    public class Scooter : IVehicle
    {
        public string Name { get; set; }
        public void Drive()
        {
            this.Name = "Scooter";
        }
    }
}
