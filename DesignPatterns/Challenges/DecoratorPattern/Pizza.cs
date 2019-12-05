using DesignPatterns.Challenges.DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Challenges.DecoratorPattern
{
    public abstract class Pizza : ISellableItem
    {
        protected string _description = "Unknown Pizza";

        public string Description
        {
            get { return this._description; }
        }
        public abstract float Cost { get; }
    }
}
