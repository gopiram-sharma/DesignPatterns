using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class NoFlyBehaviour : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I don't fly.");
        }
    }
}
