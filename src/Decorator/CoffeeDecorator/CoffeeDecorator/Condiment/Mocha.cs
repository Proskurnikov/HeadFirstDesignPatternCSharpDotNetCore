using System;
using System.Collections.Generic;
using System.Text;
using CoffeeDecorator;

namespace CoffeeDecorator.Condiment
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + ", Mocha";

        public override double Cost() => beverage.Cost() + .2;
    }
}
