using System;

namespace DesignPatterns.StrategyPattern.Behavior.Behaviors.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings!");
        }
    }
}
