namespace DesignPatterns.SingletonPattern
{
    public class PrintSpooler : IPrintSpooler
    {
        private static PrintSpooler _instance;

        private PrintSpooler() { }

        public static PrintSpooler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PrintSpooler();
                }
                return _instance;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Printing document");
        }
    }
}
