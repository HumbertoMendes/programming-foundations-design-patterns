using DesignPatterns.StrategyPattern.Behavior.Behaviors.Fly;
using DesignPatterns.StrategyPattern.Behavior.Behaviors.Quack;
using System;

namespace DesignPatterns.StrategyPattern.Behavior
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            base.FlyBehavior = new FlyNoWay();
            base.QuackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("It's a Decoy Duck!");
        }
    }
}
