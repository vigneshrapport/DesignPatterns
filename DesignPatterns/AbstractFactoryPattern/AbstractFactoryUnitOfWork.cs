using DesignPatterns.RepositoryPattern;
using DesignPatterns.UnitofWorkPattern;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class AbstractFactoryUnitOfWork : IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }
        public IOrderRepository OrderRepository { get; }

        public AbstractFactoryUnitOfWork(IRepositoryFactory factory)
        {
            ProductRepository = factory.CreateRepository<IProductRepository>();
            OrderRepository = factory.CreateRepository<IOrderRepository>();
        }

        public void Commit()
        {
            Console.WriteLine("Changes committed to the database.");
        }
    }
}
