using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecorator
{
    public abstract class Beverage
    {
        public virtual string Description { get => "Unknown beverage"; } 
        public abstract double Cost { get; }
    }
}
