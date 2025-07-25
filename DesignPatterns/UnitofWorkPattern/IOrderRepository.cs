namespace DesignPatterns.UnitofWorkPattern
{
    public interface IOrderRepository
    {
        void Add(Order order);
        Order GetById(int id);
        void Delete(int id);
    }
}
