using DesignPatterns.AdapterPattern.Interfaces;
using System;

namespace DesignPatterns.AdapterPattern
{
    class SuperDrone : IDrone
    {
        public void Beep()
        {
            Console.WriteLine("Beep!");
        }

        public void SpinRotors()
        {
            Console.WriteLine("Spinning Rotors!");
        }

        public void TakeOff()
        {
            Console.WriteLine("Taking Off!");
        }
    }
}
