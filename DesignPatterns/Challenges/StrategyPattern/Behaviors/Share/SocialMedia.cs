using System;

namespace DesignPatterns.Challenges.StrategyPattern.Behaviors.Share
{
    public class SocialMedia : IShareBehavior
    {
        public void Share()
        {
            Console.WriteLine("Sharing through Social Media");
        }
    }
}
