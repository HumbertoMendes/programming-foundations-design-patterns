using DesignPatterns.Challenges.DecoratorPattern.Interfaces;

namespace DesignPatterns.Challenges.DecoratorPattern.Decorators
{
    class Peppers : ToppingDecorator
    {
        public Peppers(ISellableItem item)
        {
            this._item = item;
        }

        public override float Cost => this._item.Cost + 0.50f;
        public override string Description => $"{this._item.Description}, Peppers";
    }
}
