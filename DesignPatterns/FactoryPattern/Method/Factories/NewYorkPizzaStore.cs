using DesignPatterns.FactoryPattern.Interfaces;
using DesignPatterns.FactoryPattern.Method.Pizzas;

namespace DesignPatterns.FactoryPattern.Method.Factories
{
    public class NewYorkPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    {
                        return new NewYorkCheesePizza();
                    }
                case "greek":
                    {
                        return new NewYorkGreekPizza();
                    }
                case "pepperoni":
                    {
                        return new NewYorkPepperoniPizza();
                    }
                case "veggie":
                    {
                        return new NewYorkVeggiePizza();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
