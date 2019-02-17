using System;
using System.Collections.Generic;
using System.Text;
using CoffeeDecorator;

namespace CoffeeDecorator.Condiment
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + ", Whip";

        public override double Cost() => beverage.Cost() + .10;
    }
}
