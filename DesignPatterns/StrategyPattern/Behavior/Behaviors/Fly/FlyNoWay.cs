using System;

namespace DesignPatterns.StrategyPattern.Behavior.Behaviors.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly? No way!");
        }
    }
}
