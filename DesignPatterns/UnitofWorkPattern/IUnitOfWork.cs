using DesignPatterns.RepositoryPattern;

namespace DesignPatterns.UnitofWorkPattern
{
    internal interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        IOrderRepository OrderRepository { get; }
        void Commit();
    }
}
