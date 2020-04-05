namespace DesignPatternApp.FactoryPattern.Model.Vehicle
{
   public class Bike  : IVehicle
    {
        public string Name { get; set; }
        public void Drive()
        {
            this.Name = "Bike";
        }
    }

   
}
