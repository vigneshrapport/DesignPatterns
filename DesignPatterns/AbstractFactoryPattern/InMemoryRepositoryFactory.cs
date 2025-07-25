using DesignPatterns.RepositoryPattern;
using DesignPatterns.UnitofWorkPattern;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class InMemoryRepositoryFactory : IRepositoryFactory
    {
        public T CreateRepository<T>() where T : class
        {
            if (typeof(T) == typeof(IProductRepository))
                return new ProductRepository() as T;
            if (typeof(T) == typeof(IOrderRepository))
                return new OrderRepository() as T;

            throw new NotSupportedException($"Repository for type {typeof(T).Name} is not supported.");
        }
    }
}
