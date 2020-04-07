namespace DesignPatternApp.FactoryPattern.Model.Car
{
    public class ToyotaFactory : ICarFactory
    {
        public  ICar Create(string name)
        {
            return  new Toyota(){Name = name};
        }
    }
}