namespace DesignPatterns.AbstractFactoryPattern
{
    public interface IRepositoryFactory
    {
        T CreateRepository<T>() where T : class;
    }
}
