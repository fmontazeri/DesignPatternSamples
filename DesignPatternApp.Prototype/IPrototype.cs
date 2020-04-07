namespace DesignPatternApp.Prototype
{
    public interface IPrototype<out TEntity> where TEntity : class
    {
        TEntity Clone();
    }
    //OR
    public abstract class AggregateRoot<TEntity> where TEntity : class
    {
        public abstract TEntity Clone();
    }
}
