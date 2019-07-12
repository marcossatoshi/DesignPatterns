using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class DecoratorBase : IDecorator
    {
        public double Preco
        {
            get
            {
                return 5.5;
            }
        }
    }

    public class DecoratorSprinkles : IDecorator
    {
        IDecorator _decorator;

        public DecoratorSprinkles(IDecorator decorator)
        {
            this._decorator = decorator;
        }

        public double Preco
        {
            get
            {
                return this._decorator.Preco + 1.0;
            }
        }
    }

    public class DecoratorCandy : IDecorator
    {
        IDecorator _decorator;

        public DecoratorCandy(IDecorator decorator)
        {
            this._decorator = decorator;
        }

        public double Preco
        {
            get
            {
                return this._decorator.Preco + 2.0;
            }
        }
    }
}
