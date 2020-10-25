using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Coffee : Beverage
    {
        public override string GetDesc()
        {
            return "Coffee";
        }

        public override decimal GetPrice()
        {
            return 1.60M;
        }
    }
}
