namespace DesignPatternApp.FactoryPattern.Model.Car
{
    public class BenzFactory : ICarFactory
    {
        public  ICar Create(string name)
        {
            return  new Benz(){Name = name};
        }
    }
}