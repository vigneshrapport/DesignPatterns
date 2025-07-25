using DesignPatterns.RepositoryPattern;

namespace DesignPatterns.UnitofWorkPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }
        public IOrderRepository OrderRepository { get; }

        public UnitOfWork()
        {
            ProductRepository = new ProductRepository();
            OrderRepository = new OrderRepository();
        }

        public void Commit()
        {
            Console.WriteLine("Changes committed to the database.");
        }
    }
}
