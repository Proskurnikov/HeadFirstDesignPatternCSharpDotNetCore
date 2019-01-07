namespace Strategy.FlyBehaviors
{
    public class FlyRockedPowered : IFlyBehavior
    {
        public void Fly() => System.Console.WriteLine("I'm flying with a rocked");
    }
}