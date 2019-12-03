using DesignPatterns.StrategyPattern.Behavior.Behaviors.Fly;
using DesignPatterns.StrategyPattern.Behavior.Behaviors.Quack;
using System;

namespace DesignPatterns.StrategyPattern.Behavior
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            base.FlyBehavior = new FlyWithWings();
            base.QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("It's a Mallard Duck!");
        }
    }
}
