namespace DesignPatterns.DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this._description = "Dark Roast Coffee";
        }

        public override float Cost => 0.99f;
    }
}
