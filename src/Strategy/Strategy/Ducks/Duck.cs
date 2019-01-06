using System;
using Strategy.FlyBehaviors;
using Strategy.QuackBehaviors;

namespace Strategy.Ducks
{
    public abstract class Duck
    {
        #region Properties
        //Of course I do not use get and set methods, insted I use Properties
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }
        
        #endregion

        #region Methods
        public abstract void Display();
        public void PerformFly() => FlyBehavior.Fly();
        public void PerformQuack() => QuackBehavior.Quack();
        public void Swim() => Console.WriteLine("All ducks float, even decoys!");
        
        #endregion
    }
}