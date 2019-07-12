using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IChainOfResponsibility
    {
        IChainOfResponsibility Next(IChainOfResponsibility chain);

        object Handle(object request);
    }
}
