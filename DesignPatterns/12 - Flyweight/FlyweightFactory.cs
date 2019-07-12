using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    public class FlyweightFactory
    {
        private List<Tuple<string, Flyweight>> flyweights = new List<Tuple<string, Flyweight>>();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args)
            {
                var tuple = new Tuple<string, Flyweight>(elem.Key(), new Flyweight(elem));
                flyweights.Add(tuple);
            }
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = sharedState.Key();

            if (flyweights.Where(t => t.Item1 == key).Count() == 0)
            {
                Console.WriteLine("FlyweightFactory: Não achou um flyweight, criando um novo.");
                this.flyweights.Add(new Tuple<string, Flyweight>(key, new Flyweight(sharedState)));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reutilizando um flyweight existente.");
            }
            return this.flyweights.Where(t => t.Item1 == key).FirstOrDefault().Item2;
        }

        public void listFlyweights()
        {
            var count = flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: Possui {count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item1);
            }
        }
    }
}
