using System;

namespace DesignPatterns.StrategyPattern.Inheritance
{
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("It's a Mallard Duck!");
        }
    }
}
