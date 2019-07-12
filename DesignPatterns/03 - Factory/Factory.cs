using System;

namespace DesignPatterns
{
    public class Factory : IFactory
    {
        public Factory() { }
        public void CriaFabrica()
        {
            Console.WriteLine("Fabrica 1 criada");
        }
    }

    public class Factory2 : IFactory
    {
        public Factory2() { }
        public void CriaFabrica()
        {
            Console.WriteLine("Fabrica 2 criada");
        }
    }

    public class Factory3 : IFactory
    {
        public Factory3() { }
        public void CriaFabrica()
        {
            Console.WriteLine("Fabrica 3 criada");
        }
    }
}
