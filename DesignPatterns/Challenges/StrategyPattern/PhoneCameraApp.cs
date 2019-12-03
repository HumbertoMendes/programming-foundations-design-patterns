using DesignPatterns.Challenges.StrategyPattern.Behaviors.Share;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Challenges.StrategyPattern
{
    abstract public class PhoneCameraApp
    {
        public IShareBehavior ShareBehavior { get; set; }

        public void Take()
        {
            Console.WriteLine("Take");
        }

        public void Save()
        {
            Console.WriteLine("Save");
        }

        public abstract void Edit();
    }
}
