using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecorator
{
    class HouseBlend : Beverage
    {
        public override string Description => "House Blend";

        public override double Cost => .89;
    }
}
