using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class GraphicDisplayBehaviour: IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("Displaying in graphic.");
        }
    }
}
