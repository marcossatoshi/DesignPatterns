using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Flyweight
    {
        public Car _sharedCar;
        public Flyweight(Car car)
        {
            this._sharedCar = car;
        }

        public void Operation (Car car)
        {
            string s = _sharedCar.Key();
            string c = car.Key();
            Console.WriteLine($"Flyweight: Mostrando carro partilhado {s} e unico {c}.");
        }
    }

    public class Car
    {
        public string Owner { get; set; }

        public string Number { get; set; }

        public string Company { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public string Key()
        {
            List<string> elements = new List<string>();

            elements.Add(this.Model);
            elements.Add(this.Color);
            elements.Add(this.Company);

            if (this.Owner != null && this.Number != null)
            {
                elements.Add(this.Number);
                elements.Add(this.Owner);
            }

            return string.Join("_", elements);
        }
    }
}
