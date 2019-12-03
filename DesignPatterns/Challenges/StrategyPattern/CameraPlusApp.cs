using DesignPatterns.Challenges.StrategyPattern.Behaviors.Share;
using System;

namespace DesignPatterns.Challenges.StrategyPattern
{
    public class CameraPlusApp : PhoneCameraApp
    {
        public CameraPlusApp()
        {
            base.ShareBehavior = new SocialMedia();
        }

        public override void Edit()
        {
            Console.WriteLine("CameraPlusApp Edit");
        }
    }
}
