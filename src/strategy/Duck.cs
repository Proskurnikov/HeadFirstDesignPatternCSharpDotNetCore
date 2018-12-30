namespace strategy
{
    public abstract class Duck
    {
        public FlyBehavior FlyBehavior { get; set; }
        public QuackBehavior QuackBehavior { get; set; }
        public abstract void Display();
        public void PerfomFly() => FlyBehavior.Fly();
        public void PerfomQuack() => QuackBehavior.Quack();
    }
}