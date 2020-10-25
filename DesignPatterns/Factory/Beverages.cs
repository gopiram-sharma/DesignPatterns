using DesignPatterns.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public static class Beverages
    {
        public static void MakeCoffee()
        {
            Coffee coffee = new Coffee();
            SoyMilk soyMilk = new SoyMilk(coffee);
            Sugar sugar = new Sugar(soyMilk);
            WhippedCream cream = new WhippedCream(sugar);

            Console.WriteLine(cream.GetDesc());
            Console.WriteLine(cream.GetPrice());
        }

        public static void MakeTea()
        {
            Tea tea = new Tea();
            SoyMilk soyMilk = new SoyMilk(tea);
            Sugar sugar = new Sugar(soyMilk);

            Console.WriteLine(sugar.GetDesc());
            Console.WriteLine(sugar.GetPrice());
        }
    }
}
