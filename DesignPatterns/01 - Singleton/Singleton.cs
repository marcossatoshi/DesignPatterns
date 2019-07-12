using System;

namespace DesignPatterns
{
    public class Singleton
    {
        static Singleton _instancia;
        public static Singleton Instancia
        {
            get { return _instancia ?? (_instancia = new Singleton()); }
        }
        public Singleton() { }
        public string Mensagem { get; set; }
    }
}