using System;

namespace DesignPatterns.StrategyPattern.Inheritance
{
    // Decoy Duck having to override methods it's not supposed to inherit and implementing no behaviors can become a problem
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("It's a Decoy Duck!");
        }

        public override void Quack()
        {
            // Do nothing because decoy ducks don't make any sound.
        }

        public override void Fly()
        {
            // Do nothing because decoy ducks don't fly.
        }
    }
}
