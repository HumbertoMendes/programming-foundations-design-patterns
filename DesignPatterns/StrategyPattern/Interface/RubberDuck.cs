using System;

namespace DesignPatterns.StrategyPattern.Interface
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("It's a Decoy Duck!");
        }
    }
}
