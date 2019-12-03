using DesignPatterns.Challenges.StrategyPattern.Behaviors.Share;
using System;

namespace DesignPatterns.Challenges.StrategyPattern
{
    public class BasicCameraApp : PhoneCameraApp
    {
        public BasicCameraApp()
        {
            base.ShareBehavior = new Email();
        }

        public override void Edit()
        {
            Console.WriteLine("BasicCameraApp Edit");
        }
    }
}
