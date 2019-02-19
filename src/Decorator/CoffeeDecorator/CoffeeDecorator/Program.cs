using System;
using CoffeeDecorator.Condiment;

namespace CoffeeDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Decorator Pattern ***");

            Beverage beverage = new SteamedMilk(
                new Whip(
                new Whip(
                new Espresso())));

            Console.WriteLine(beverage.Description + " $" + beverage.Cost);

            Beverage beverage1 = new HouseBlend();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Soy(beverage1);

            Console.WriteLine(beverage1.Description + " $" + beverage1.Cost);

            Console.ReadLine();
        }
    }
}
