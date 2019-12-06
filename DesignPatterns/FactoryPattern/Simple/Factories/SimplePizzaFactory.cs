using DesignPatterns.FactoryPattern.Interfaces;
using DesignPatterns.FactoryPattern.Simple.Pizzas;

namespace DesignPatterns.FactoryPattern.Simple.Factories
{
    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(string type)
        {
            switch(type)
            {
                case "cheese":
                    {
                        return new CheesePizza();
                    }
                case "greek":
                    {
                        return new GreekPizza();
                    }
                case "pepperoni":
                    {
                        return new PepperoniPizza();
                    }
                case "veggie":
                    {
                        return new VeggiePizza();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
