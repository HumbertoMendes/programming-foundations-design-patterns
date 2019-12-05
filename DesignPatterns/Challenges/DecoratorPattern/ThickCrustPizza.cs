using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Challenges.DecoratorPattern
{
    public class ThickCrustPizza : Pizza
    {
        public ThickCrustPizza()
        {
            this._description = "Thick crust pizza";
        }

        public override float Cost => 12.00f;
    }
}
