using System;
using DesignPatterns.StrategyPattern.Behavior.Behaviors.Fly;
using DesignPatterns.StrategyPattern.Behavior.Behaviors.Quack;

namespace DesignPatterns.StrategyPattern.Behavior
{
    abstract public class Duck
    {
        protected IFlyBehavior FlyBehavior { get; set; }
        protected IQuackBehavior QuackBehavior { get; set; }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Swim!");
        }

        public abstract void Display();
    }
}
