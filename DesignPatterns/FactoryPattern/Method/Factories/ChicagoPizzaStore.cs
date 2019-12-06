using DesignPatterns.FactoryPattern.Interfaces;
using DesignPatterns.FactoryPattern.Method.Pizzas;

namespace DesignPatterns.FactoryPattern.Method.Factories
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    {
                        return new ChicagoCheesePizza();
                    }
                case "greek":
                    {
                        return new ChicagoGreekPizza();
                    }
                case "pepperoni":
                    {
                        return new ChicagoPepperoniPizza();
                    }
                case "veggie":
                    {
                        return new ChicagoVeggiePizza();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
