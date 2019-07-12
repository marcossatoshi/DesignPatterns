using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class OperationBridgeA : IBridge
    {
        public string OperationImplementation()
        {
            return "Operacao bridge A";
        }
    }

    public class OperationBridgeB : IBridge
    {
        public string OperationImplementation()
        {
            return "Operacao bridge B";
        }
    }

    public class Client
    {
        public void ClientCode(Bridge brigde)
        {
            brigde.Operation();
        }
    }
}
