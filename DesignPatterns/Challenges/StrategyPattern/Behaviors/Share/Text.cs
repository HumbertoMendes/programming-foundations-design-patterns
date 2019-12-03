using System;

namespace DesignPatterns.Challenges.StrategyPattern.Behaviors.Share
{
    class Text : IShareBehavior
    {
        public void Share()
        {
            Console.WriteLine("Sharing through Text");
        }
    }
}
