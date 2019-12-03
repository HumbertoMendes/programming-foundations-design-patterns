using DesignPatterns.StrategyPattern.Behavior.Behaviors.Fly;
using DesignPatterns.StrategyPattern.Behavior.Behaviors.Quack;
using System;

namespace DesignPatterns.StrategyPattern.Behavior
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            base.FlyBehavior = new FlyNoWay();
            base.QuackBehavior = new Silent();
        }

        public override void Display()
        {
            Console.WriteLine("It's a Decoy Duck!");
        }
    }
}
