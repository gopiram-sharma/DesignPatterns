using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class TextQuackBehaviour: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quacking in text.");
        }
    }
}
