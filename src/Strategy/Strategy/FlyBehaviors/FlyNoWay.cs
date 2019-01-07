namespace Strategy.FlyBehaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly() => System.Console.WriteLine("I can't fly");
    }
}