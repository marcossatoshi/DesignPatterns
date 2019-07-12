using System;

namespace DesignPatterns
{
    public class Strategy
    {
        private IStrategy _strategy;
        public Strategy() { }

        public void SetPrint(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecutePrint()
        {
            _strategy.print();
        }
    }

    public class FileTxt : IStrategy
    {
        public FileTxt() { }
        public void print()
        {
            Console.WriteLine("Imprimindo arquivo txt");
        }
    }

    public class FilePDF : IStrategy
    {
        public FilePDF() { }
        public void print()
        {
            Console.WriteLine("Imprimindo arquivo pdf");
        }
    }
}
