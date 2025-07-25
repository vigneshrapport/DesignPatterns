namespace DesignPatterns.RepositoryPattern
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(int id)
        {
            Product product = GetById(id);
            if (product != null)
                _products.Remove(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.Single(s => s.Id == id);
        }
    }
}
