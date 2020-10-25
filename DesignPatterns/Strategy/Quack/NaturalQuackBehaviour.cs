using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class NaturalQuackBehaviour: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quacking naturally.");
        }
    }
}
