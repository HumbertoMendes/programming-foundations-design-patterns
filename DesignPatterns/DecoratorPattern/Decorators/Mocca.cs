namespace DesignPatterns.DecoratorPattern.Decorators
{
    public class Mocca : CondimentDecorator
    {
        private Beverage _beverage;

        public Mocca(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string Description => $"{this._beverage.Description}, Mocca";
        public override float Cost => this._beverage.Cost + 0.10f;
    }
}
