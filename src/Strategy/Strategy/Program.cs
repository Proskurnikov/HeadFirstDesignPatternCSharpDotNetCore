using System;
using Strategy.Ducks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Strategy ***");
            
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            #if (!vscode) // Add this for run from VS in order to console window will keep open
            Console.WriteLine("Press Enter for exit");
            Console.ReadLine();
            #endif
        }
    }
}
