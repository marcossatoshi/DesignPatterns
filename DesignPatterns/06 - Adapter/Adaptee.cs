using System;


namespace DesignPatterns
{
    public class Adaptee
    {
        private bool isOn;
        public bool IsOn
        {
            get
            {
                return this.isOn;
            }
            set
            {
                this.isOn = value;
                Console.WriteLine("Está {0}ligando", this.isOn ? "" : "des");
            }
        }
    }
}
