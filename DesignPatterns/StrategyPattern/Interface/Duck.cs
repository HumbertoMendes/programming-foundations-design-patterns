using System;

namespace DesignPatterns.StrategyPattern.Interface
{
    abstract public class Duck
    {
        public void Swim()
        {
            Console.WriteLine("Swim!");
        }

        public abstract void Display();
    }
}
