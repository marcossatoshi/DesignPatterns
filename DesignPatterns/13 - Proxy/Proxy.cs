using System;

namespace DesignPatterns
{
    public class Proxy : ISubject
    {
        private Subject _subject;

        public Proxy(Subject subject)
        {
            this._subject = subject;
        }

        public void Request()
        {
            if (this.CheckAccess())
            {
                this._subject = new Subject();
                this._subject.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Verificando acesso.");
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Criando log de acesso.");
        }

    }

    public class ClientProxy
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }

}
