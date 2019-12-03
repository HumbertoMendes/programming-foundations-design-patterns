using System;

namespace DesignPatterns.StrategyPattern.Interface
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("It's a Decoy Duck!");
        }
    }
}
