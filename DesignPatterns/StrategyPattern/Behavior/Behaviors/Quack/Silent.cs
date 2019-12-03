using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.Behavior.Behaviors.Quack
{
    public class Silent : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
