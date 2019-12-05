using DesignPatterns.DecoratorPattern.Decorators;
using System;

namespace DesignPatterns.DecoratorPattern
{
    public class StarbuzzCoffee
    {
        public static void MakeOrder()
        {
            Beverage beverage = new DarkRoast();
            beverage = new Mocca(beverage);
            beverage = new Mocca(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine($"{beverage.Description}: ${beverage.Cost}");
        }
    }
}
