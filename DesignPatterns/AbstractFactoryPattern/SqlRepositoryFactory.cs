namespace DesignPatterns.AbstractFactoryPattern
{
    public class SqlRepositoryFactory : IRepositoryFactory
    {
        public T CreateRepository<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
