using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public abstract class Beverage
    {
        public abstract string GetDesc();
        public abstract decimal GetPrice();
    }
}
