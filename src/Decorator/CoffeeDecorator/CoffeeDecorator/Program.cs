using System;
using CoffeeDecorator.Condiment;

namespace CoffeeDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Decorator Pattern ***");

            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + " $" + beverage.Cost);

            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);

            Console.WriteLine(beverage.Description + " $" + beverage.Cost);

            Console.ReadLine();
        }
    }
}
