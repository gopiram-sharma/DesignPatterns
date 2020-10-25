namespace DesignPatterns.Decorator
{
    public class Sugar : Addon
    {
        private Beverage _beverage;
        public Sugar(Beverage beverage)
        {
            _beverage = beverage; 
        }
        public override string GetDesc()
        {
            return _beverage.GetDesc() + " + Sugar";
        }

        public override decimal GetPrice()
        {
            return _beverage.GetPrice() + 0M ;
        }
    }
}
