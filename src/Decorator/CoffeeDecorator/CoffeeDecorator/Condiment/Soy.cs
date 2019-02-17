using System;
using System.Collections.Generic;
using System.Text;
using CoffeeDecorator;

namespace CoffeeDecorator.Condiment
{
    class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + ", Soy";

        public override double Cost() => beverage.Cost() + .15;
    }
}
