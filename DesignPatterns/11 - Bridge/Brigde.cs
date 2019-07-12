using System;

namespace DesignPatterns
{
    public class Bridge
    {
        protected IBridge _bridge;

        public Bridge(IBridge bridge)
        {
            this._bridge = bridge;
        }

        public virtual void Operation()
        {
            Console.WriteLine("Operação normal + " + _bridge.OperationImplementation());
        }
    }

    public class BridgeAdvance : Bridge
    {
        public BridgeAdvance(IBridge bridge) : base(bridge)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("Operação avançada + " + base._bridge.OperationImplementation());
        }
    }
}
