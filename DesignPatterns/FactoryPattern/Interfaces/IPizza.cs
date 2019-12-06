using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern.Interfaces
{
    public interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}
