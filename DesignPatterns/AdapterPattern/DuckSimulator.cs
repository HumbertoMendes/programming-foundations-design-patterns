using DesignPatterns.AdapterPattern.Interfaces;
using System;

namespace DesignPatterns.AdapterPattern
{
    static public class DuckSimulator
    {
        static public void TestSimulator()
        {
            Console.WriteLine("Mallard Duck");
            TestDuck(new MallardDuck());
            Console.WriteLine();
            Console.WriteLine("Wild Turkey");
            TestDuck(new TurkeyAdapter(new WildTurkey()));
            Console.WriteLine();
            Console.WriteLine("Super Drone");
            TestDuck(new DroneAdapter(new SuperDrone()));
            Console.WriteLine();
        }

        static private void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
