using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class DigitalQuackBehaviour: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quacking digitally.");
        }
    }
}
