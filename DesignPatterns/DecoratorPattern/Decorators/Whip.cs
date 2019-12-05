using System;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string Description => $"{this._beverage.Description}, Whip";
        public override float Cost => this._beverage.Cost + 0.10f;
    }
}
