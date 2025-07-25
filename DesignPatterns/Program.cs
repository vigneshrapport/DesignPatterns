using DesignPatterns.FactoryPattern;
using DesignPatterns.RepositoryPattern;
using DesignPatterns.SingletonPattern;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Factory Pattern

                IShapeFactory shapeFactory = new ShapeFactory();

                // Create and draw a Circle
                IShape circle = shapeFactory.CreateShape(ShapeType.Circle);
                circle.Draw();

                // Create and draw a Rectangle
                IShape rectangle = shapeFactory.CreateShape(ShapeType.Rectangle);
                rectangle.Draw();

                /* Dynamically add a new shape at runtime
                 * shapeFactory.RegisterShape(ShapeType.Triangle, () => new Triangle());
                 * IShape triangle = shapeFactory.CreateShape(ShapeType.Triangle);
                 * triangle.Draw();
                 */

                #endregion

                #region Singleton Pattern

                // Using the non-thread-safe singleton
                IPrintSpooler instance1 = PrintSpooler.Instance;
                instance1.Print();
                IPrintSpooler instance2 = PrintSpooler.Instance;
                instance2.Print();
                Console.WriteLine(Object.ReferenceEquals(instance1, instance2)
                ? "Same instance (non-thread-safe singleton confirmed)"
                : "Different instances (non-thread-safe singleton failed)");

                //Using the thread-safe singleton
                IPrintSpooler threadSafeInstance1 = ThreadSafePrintSpooler.Instance;
                threadSafeInstance1.Print();
                IPrintSpooler threadSafeInstance2 = ThreadSafePrintSpooler.Instance;
                threadSafeInstance2.Print();
                Console.WriteLine(Object.ReferenceEquals(threadSafeInstance1, threadSafeInstance2)
                ? "Same instance (thread-safe singleton confirmed)"
                : "Different instances (thread-safe singleton failed)");

                //Lazy initialization of the thread-safe singleton
                IPrintSpooler lazyInstance1 = LazyPrintSpooler.Instance;
                lazyInstance1.Print();
                IPrintSpooler lazyInstance2 = LazyPrintSpooler.Instance;
                lazyInstance2.Print();
                Console.WriteLine(Object.ReferenceEquals(lazyInstance1, lazyInstance2)
                ? "Same instance (Lazy initialization of the thread-safe singleton confirmed)"
                : "Different instances (Lazy initialization of the thread-safe singleton failed)");

                //builder.Services.AddSingleton<IPrintSpooler>(provider => LazyPrintSpooler.Instance);
                //builder.Services.AddSingleton<IPrintSpooler>(provider => ThreadSafePrintSpooler.Instance);
                //builder.Services.AddSingleton<IPrintSpooler>(provider => PrintSpooler.Instance);
                #endregion

                #region Repository Pattern
                IProductRepository productRepository = new ProductRepository();
                // Adding products
                productRepository.Add(new Product { Id = 1, Name = "Laptop", Price = 1200.00m });
                productRepository.Add(new Product { Id = 2, Name = "Smartphone", Price = 800.00m });
                // Retrieving products
                IEnumerable<Product> products = productRepository.GetAll();
                //Deleting a product
                productRepository.Delete(1);
                //Getting a product by ID
                Product product = productRepository.GetById(2);
                #endregion

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
