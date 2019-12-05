using DesignPatterns.Challenges.DecoratorPattern.Interfaces;

namespace DesignPatterns.Challenges.DecoratorPattern.Decorators
{
    class Olives : ToppingDecorator
    {
        public Olives(ISellableItem item)
        {
            this._item = item;
        }

        public override float Cost => this._item.Cost + 0.25f;
        public override string Description => $"{this._item.Description}, Olives";
    }
}
