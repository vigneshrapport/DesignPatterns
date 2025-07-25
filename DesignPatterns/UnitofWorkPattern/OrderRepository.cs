namespace DesignPatterns.UnitofWorkPattern
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new();

        public void Add(Order order)
        {
            _orders.Add(order);
        }

        public void Delete(int id)
        {
            Order order = GetById(id);
            _orders.Remove(order);
        }

        public Order GetById(int id)
        {
            return _orders.Single(o => o.Id == id);
        }
    }
}
