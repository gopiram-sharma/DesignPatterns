using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class NaturalDisplayBehaviour: IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("Displaying naturally.");
        }
    }
}
