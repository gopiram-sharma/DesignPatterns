using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class JetFlyBehaviour : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I fly mechanically and fast.");
        }
    }
}
