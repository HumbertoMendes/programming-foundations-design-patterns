using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.Behavior.Behaviors.Quack
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
