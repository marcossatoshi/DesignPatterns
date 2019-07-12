using System;

namespace DesignPatterns
{
    public class Adapter : Adaptee, IAdapter
    {
        public String On()
        {
            this.IsOn = true;
            return "Está ligado";
        }

        public String Off()
        {
            this.IsOn = false;
            return "Está desligado";
        }
    }

    public class Adapter2 : Adaptee, IAdapter
    {
        public String On()
        {
            this.IsOn = true;
            this.DoStuff();
            this.DoOtherStuff();
            this.DoAnotherStuff();
            return "Está ligado";
        }

        public String Off()
        {
            this.IsOn = false;
            return "Está desligado";
        }

        public void DoStuff()
        {
            Console.WriteLine("Fez algo");
        }
        public void DoOtherStuff()
        {
            Console.WriteLine("Fez outro algo");
        }
        public void DoAnotherStuff()
        {
            Console.WriteLine("Fez mais algo");
        }
    }
}
