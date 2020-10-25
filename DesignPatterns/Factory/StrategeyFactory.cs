using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public static class StrategeyFactory
    {
        public static void CreateDucks()
        {
            DomesticDuck duck = new DomesticDuck(new NaturalDisplayBehaviour(), new NormalFlyBehaviour(), new NaturalQuackBehaviour());
            duck.Fly();
            duck.Quack();
            duck.Display();
        }
    }
}
