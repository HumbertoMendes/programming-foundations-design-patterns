using DesignPatterns.Challenges.DecoratorPattern.Interfaces;

namespace DesignPatterns.Challenges.DecoratorPattern.Decorators
{
    public abstract class ToppingDecorator : ISellableItem
    {
        protected ISellableItem _item;

        public abstract float Cost { get; }
        public abstract string Description { get; }
    }
}
