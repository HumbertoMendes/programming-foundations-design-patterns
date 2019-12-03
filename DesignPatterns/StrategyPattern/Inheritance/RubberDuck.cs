using System;

namespace DesignPatterns.StrategyPattern.Inheritance
{
    // Decoy Duck having to override methods it's not supposed to inherit or changing their behaviors can become a problem
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("It's a Decoy Duck!");
        }

        public override void Quack()
        {
            Console.WriteLine("Squeak");
        }

        public override void Fly()
        {
            // Do nothing because rubber ducks don't fly
        }
    }
}
