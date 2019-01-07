using System;
using Strategy.Ducks;
using Strategy.FlyBehaviors;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Strategy ***\n");

            Console.WriteLine("=> Mallard Duck");
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            Console.WriteLine();

            Console.WriteLine("=> Model Duck");
            Duck model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = new FlyRockedPowered();
            model.PerformFly();
            Console.WriteLine();

#if (!vscode) // Add this for run from VS in order to console window will keep open
            Console.WriteLine("Press Enter for exit");
            Console.ReadLine();
#endif
        }
    }
}
