using DesignPatterns.FactoryPattern.Interfaces;
using System;

namespace DesignPatterns.FactoryPattern.Simple.Pizzas
{
    public class VeggiePizza : IPizza
    {
        public void Bake()
        {
            throw new NotImplementedException();
        }

        public void Box()
        {
            throw new NotImplementedException();
        }

        public void Cut()
        {
            throw new NotImplementedException();
        }

        public void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
