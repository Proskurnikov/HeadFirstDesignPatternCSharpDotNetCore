using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecorator
{
    public abstract class Beverage
    {
        public virtual string Description { get; protected set; } = "Unknown Beverage";
        public abstract double Cost { get; }
    }
}
