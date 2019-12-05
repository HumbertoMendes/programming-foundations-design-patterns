using DesignPatterns.Challenges.DecoratorPattern.Interfaces;

namespace DesignPatterns.Challenges.DecoratorPattern.Decorators
{
    public class Cheese : ToppingDecorator
    {
        public Cheese(ISellableItem item)
        {
            this._item = item;
        }

        public override float Cost => this._item.Cost + 0.99f;
        public override string Description => $"{this._item.Description}, Cheese";
    }
}
