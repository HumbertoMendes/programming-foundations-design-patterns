using System;

namespace DesignPatterns.StrategyPattern.Inheritance
{
    public class ReadheadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("It's a Readhead Duck!");
        }
    }
}
