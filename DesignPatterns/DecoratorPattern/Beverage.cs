namespace DesignPatterns.DecoratorPattern
{
    abstract public class Beverage
    {
        protected string _description = "Unknown Beverage";

        public virtual string Description
        {
            get { return this._description; }
        }

        public abstract float Cost { get; }
    }
}
