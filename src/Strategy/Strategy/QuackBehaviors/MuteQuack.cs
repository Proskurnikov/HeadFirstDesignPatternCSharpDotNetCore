namespace Strategy.QuackBehaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack() => System.Console.WriteLine("<< Silence >>");
    }
}