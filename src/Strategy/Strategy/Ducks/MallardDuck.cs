using Strategy.QuackBehaviors;
using Strategy.FlyBehaviors;

namespace Strategy.Ducks
{
    public class MallardDuck : Duck
    {
        #region Ctors
        
        public MallardDuck()
        {
            QuackBehavior = new SimpleQuack();
            FlyBehavior = new FlyWithWings();
        }

        #endregion

        #region Override Methods
        public override void Display() => System.Console.WriteLine("I'm a real Mallard duck");
        
        #endregion
    }
}