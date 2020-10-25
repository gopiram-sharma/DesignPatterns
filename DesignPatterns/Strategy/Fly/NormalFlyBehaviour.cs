using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class NormalFlyBehaviour : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I fly naturally.");
        }
    }
}
