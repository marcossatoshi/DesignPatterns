using System;

namespace DesignPatterns
{
    public class Facade
    {
        public Facade()
        {
        }

        public void MetodoGeral()
        {
            DoStuff();
            DoAnotherStuff();
            DoOtherStuff();
        }

        private void DoStuff()
        {
            Console.WriteLine("Fiz algo");
        }

        private void DoOtherStuff()
        {
            Console.WriteLine("Fiz outro algo");
        }

        private void DoAnotherStuff()
        {
            Console.WriteLine("Fiz mais outro algo");
        }
    }
}
