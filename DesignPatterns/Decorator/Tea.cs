using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Tea : Beverage
    {
        public override string GetDesc()
        {
            return "Tea";
        }

        public override decimal GetPrice()
        {
            return 1.20M;
        }
    }
}
