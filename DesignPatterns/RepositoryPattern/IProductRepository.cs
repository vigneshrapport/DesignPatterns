namespace DesignPatterns.RepositoryPattern
{
    public interface IProductRepository
    {
        Product GetById(int id);
        IEnumerable<Product> GetAll();
        void Add(Product product);
        void Delete(int id);
    }
}
