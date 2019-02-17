using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecorator.Condiment
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string Description { get; }
    }
}
