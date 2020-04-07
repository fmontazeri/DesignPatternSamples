namespace DesignPatternApp.FactoryPattern.Model.Car
{
    public interface ICarFactory
    {
        ICar Create(string name);
    }
}