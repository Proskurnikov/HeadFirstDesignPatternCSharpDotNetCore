using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecorator
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
