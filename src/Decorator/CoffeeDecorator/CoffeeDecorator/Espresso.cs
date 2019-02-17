using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecorator
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost => 1.99;
    }
}
