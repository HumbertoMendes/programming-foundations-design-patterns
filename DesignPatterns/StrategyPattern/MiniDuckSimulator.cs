using DesignPatterns.StrategyPattern.Behavior;

namespace DesignPatterns.StrategyPattern
{
    class MiniDuckSimulator
    {
        static public void TestDuckBehaviors()
        {
            var mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            var readheadDuck = new ReadheadDuck();
            readheadDuck.Display();
            readheadDuck.PerformFly();
            readheadDuck.PerformQuack();

            var rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();

            var decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();
        }

    }
}
