using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DomesticDuck duck = new DomesticDuck(new NaturalDisplayBehaviour(), new NormalFlyBehaviour(), new NaturalQuackBehaviour());
            duck.Fly();
            duck.Quack();
            duck.Display();
            Console.ReadLine();
        }
    }
}
