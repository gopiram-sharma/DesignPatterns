namespace DesignPatterns.Decorator
{
    public class WhippedCream : Addon
    {
        private Beverage _beverage;
        public WhippedCream(Beverage beverage)
        {
            _beverage = beverage; 
        }
        public override string GetDesc()
        {
            return _beverage.GetDesc() + " + Whipped cream";
        }

        public override decimal GetPrice()
        {
            return _beverage.GetPrice() + 0.25M ;
        }
    }
}
