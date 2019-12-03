using System;

namespace DesignPatterns.StrategyPattern.Inheritance
{
    abstract public class Duck
    {
        public void Swim()
        {
            Console.WriteLine("Swim!");
        }

        public virtual void Quack()
        {
            Console.WriteLine("Quack!");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Fly!");
        }

        public abstract void Display();
    }
}
