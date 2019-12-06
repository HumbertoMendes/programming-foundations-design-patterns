using DesignPatterns.FactoryPattern.Interfaces;

namespace DesignPatterns.FactoryPattern.Method
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(string type)
        {
            IPizza pizza = this.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        // Defer the pizza creation to the concrete classes
        public abstract IPizza CreatePizza(string type);
    }
}
