using System;

namespace DesignPatterns.Challenges.StrategyPattern.Behaviors.Share
{
    public class Email : IShareBehavior
    {
        public void Share()
        {
            Console.WriteLine("Sharing through Email");
        }
    }
}
