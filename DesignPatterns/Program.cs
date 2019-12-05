using DesignPatterns.AdapterPattern;
using DesignPatterns.Challenges.DecoratorPattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.StrategyPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strategy Pattern
            // MiniDuckSimulator.TestDuckBehaviors();
            // Challenge
            // DuckSimulator.TestSimulator();

            // Decorator Pattern
            // StarbuzzCoffee.MakeOrder();
            // Challenge
            MegaPizza.MakeOrder();

            Console.ReadKey();
        }
    }
}
