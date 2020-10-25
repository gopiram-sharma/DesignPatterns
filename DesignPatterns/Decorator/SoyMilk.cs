namespace DesignPatterns.Decorator
{
    public class SoyMilk : Addon
    {
        private Beverage _beverage;
        public SoyMilk(Beverage beverage)
        {
            _beverage = beverage; 
        }
        public override string GetDesc()
        {
            return _beverage.GetDesc() + " + Soy milk";
        }

        public override decimal GetPrice()
        {
            return _beverage.GetPrice() + 0.25M ;
        }
    }
}
