using DesignPatterns.StrategyPattern.Interface.Interfaces;
using System;

namespace DesignPatterns.StrategyPattern.Interface
{
    // MallardDuck implementing the IFlyable and IQuackable causes duplicate on the code since RedheadDuck also implement the same interfaces with exact same behaviors
    public class ReadheadDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("It's a Readhead Duck!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
        }

        public void Fly()
        {
            Console.WriteLine("Fly!");
        }
    }
}
