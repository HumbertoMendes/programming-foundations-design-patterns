using DesignPatterns.FactoryPattern.Interfaces;
using DesignPatterns.FactoryPattern.Simple.Factories;

namespace DesignPatterns.FactoryPattern.Simple
{
    public class PizzaStore
    {
        private SimplePizzaFactory _pizzaFactory;

        public PizzaStore(SimplePizzaFactory pizzaFactory)
        {
            this._pizzaFactory = pizzaFactory;
        }

        public IPizza OrderPizza(string type)
        {
            // Pass the pizza type to create the pizza
            IPizza pizza = this._pizzaFactory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
