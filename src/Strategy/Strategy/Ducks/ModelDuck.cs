using System;
using Strategy.FlyBehaviors;
using Strategy.QuackBehaviors;

namespace Strategy.Ducks
{
    public class ModelDuck : Duck
    {
        #region Ctors
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new SimpleQuack();
        }

        #endregion
        
        #region Override Methods
        public override void Display() => Console.WriteLine("I'm model duck");

        #endregion
    }
}