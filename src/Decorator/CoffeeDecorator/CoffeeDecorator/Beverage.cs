using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDecorator
{
    public abstract class Beverage
    {
        public enum BeverageSize
        {
            Tall,
            Grande,
            Venti
        }

        public virtual BeverageSize Size { get => BeverageSize.Grande; }

        public virtual string Description { get => Size.ToString(); } 
        public abstract double Cost { get; }
    }
}
