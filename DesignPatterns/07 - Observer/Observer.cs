using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class ObserverA : IObserver
    {
        public void ReceiveWhatsapp()
        {
            Console.WriteLine("Mensagem recebida pelo observer A");
        }
    }

    public class ObserverB : IObserver
    {
        public void ReceiveWhatsapp()
        {
            Console.WriteLine("Mensagem recebida pelo observer B");
        }
    }

    public class ObserverC : IObserver
    {
        public void ReceiveWhatsapp()
        {
            Console.WriteLine("Mensagem recebida pelo observer C");
        }
    }

    public class ObserverSupport : IObserverSupport
    {
        private readonly List<IObserver> _observer;

        public ObserverSupport()
        {
            _observer = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            _observer.Add(observer);
        }

        public void Delete(IObserver observer)
        {
            _observer.Remove(observer);
        }

        public void SendMessage()
        {
            foreach (var item in _observer)
            {
                item.ReceiveWhatsapp();
            }
        }
    }
}
