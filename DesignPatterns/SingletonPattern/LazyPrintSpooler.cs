namespace DesignPatterns.SingletonPattern
{
    public class LazyPrintSpooler : IPrintSpooler
    {
        private static readonly Lazy<LazyPrintSpooler> _instance =
            new Lazy<LazyPrintSpooler>(() => new LazyPrintSpooler());

        private LazyPrintSpooler() { }

        public static LazyPrintSpooler Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void Print()
        {
            Console.WriteLine("Printing document from lazy initialized singleton instance");
        }
    }
}
