using System;

namespace DesignPatterns
{
    public interface IObserverSupport
    {
        void Register(IObserver observer);
        void Delete(IObserver observer);
        void SendMessage();
    }
}
