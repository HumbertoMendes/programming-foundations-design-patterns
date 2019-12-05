using DesignPatterns.Challenges.DecoratorPattern.Decorators;
using DesignPatterns.Challenges.DecoratorPattern.Interfaces;
using System;

namespace DesignPatterns.Challenges.DecoratorPattern
{
    static class MegaPizza
    {
        static public void MakeOrder()
        {
            ISellableItem thinCrustPizza = new ThinCrustPizza();
            thinCrustPizza = new Cheese(thinCrustPizza);
            thinCrustPizza = new Olives(thinCrustPizza);
            thinCrustPizza = new Peppers(thinCrustPizza);
            Console.WriteLine($"{thinCrustPizza.Description}: {thinCrustPizza.Cost}");

            ISellableItem thickCrustPizza = new ThickCrustPizza();
            thickCrustPizza = new Cheese(thickCrustPizza);
            thickCrustPizza = new Olives(thickCrustPizza);
            thickCrustPizza = new Peppers(thickCrustPizza);
            Console.WriteLine($"{thickCrustPizza.Description}: {thickCrustPizza.Cost}");
        }
    }
}
