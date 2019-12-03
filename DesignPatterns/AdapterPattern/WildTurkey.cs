using DesignPatterns.AdapterPattern.Interfaces;
using System;

namespace DesignPatterns.AdapterPattern
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Flapping Wings!");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble!");
        }
    }
}
