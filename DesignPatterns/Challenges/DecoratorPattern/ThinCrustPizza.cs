using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Challenges.DecoratorPattern
{
    public class ThinCrustPizza : Pizza
    {
        public ThinCrustPizza()
        {
            this._description = "Thin Crust Pizza";
        }

        public override float Cost => 10.00f;
    }
}
