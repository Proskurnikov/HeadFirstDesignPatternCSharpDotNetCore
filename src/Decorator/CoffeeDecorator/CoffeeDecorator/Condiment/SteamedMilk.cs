using System;
using System.Collections.Generic;
using System.Text;
using CoffeeDecorator;

namespace CoffeeDecorator.Condiment
{
    class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + ", Steamed Milk";

        public override double Cost() => beverage.Cost() + .10;
    }
}
