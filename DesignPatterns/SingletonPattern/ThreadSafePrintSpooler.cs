namespace DesignPatterns.SingletonPattern
{
    public class ThreadSafePrintSpooler : IPrintSpooler
    {
        private readonly static object _lock = new object();

        private static ThreadSafePrintSpooler _instance;

        private ThreadSafePrintSpooler() { }

        public static ThreadSafePrintSpooler Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ThreadSafePrintSpooler();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Printing document from thread-safe singleton instance");
        }
    }
}
