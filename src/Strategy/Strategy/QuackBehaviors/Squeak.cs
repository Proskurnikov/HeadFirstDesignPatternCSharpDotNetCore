namespace Strategy.QuackBehaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack() => System.Console.WriteLine("Sqeak");
    }
}