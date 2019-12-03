using DesignPatterns.AdapterPattern.Interfaces;
using System;

namespace DesignPatterns.AdapterPattern
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Gliding!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
