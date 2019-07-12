using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public abstract class ChainOfResponsibility : IChainOfResponsibility
    {
        private IChainOfResponsibility _chain;

        public IChainOfResponsibility Next(IChainOfResponsibility chain)
        {
            this._chain = chain;
            return chain;
        }

        public virtual object Handle(object request)
        {
            if (this._chain != null)
            {
                return this._chain.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }

    public class ProgrammerHandler : ChainOfResponsibility
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Codigo")
            {
                return $"Programmer: Eu manipulo esse {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    public class DesignHandler : ChainOfResponsibility
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Imagem")
            {
                return $"Design: Eu manipulo essa {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    public class OpsHandler : ChainOfResponsibility
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Deploy")
            {
                return $"Ops: Eu manipulo esse {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class ClientChain
    {
        // The client code is usually suited to work with a single handler. In
        // most cases, it is not even aware that the handler is part of a chain.
        public static void ClientCode(ChainOfResponsibility handler)
        {
            foreach (var request in new List<string> { "Codigo", "Imagem", "Café" })
            {
                Console.WriteLine($"Cliente: Quem manipula {request}?");

                var result = handler.Handle(request);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {request} não foi manipulado.");
                }
            }
        }
    }
}
