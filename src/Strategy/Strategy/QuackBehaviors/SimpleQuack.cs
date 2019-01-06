namespace Strategy.QuackBehaviors
{
    //SimpleQuack is like Quack class in the book. This name was changed because msbuild compiler said "'Quack': member names cannot be the same as their enclosing type [Strategy]"
    public class SimpleQuack : IQuackBehavior
    {
        public void Quack() => System.Console.WriteLine("Quack");
    }
}