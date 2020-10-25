namespace DesignPatterns.Decorator
{
    public class Chocolate : Addon
    {
        private Beverage _beverage;
        public Chocolate(Beverage beverage)
        {
            _beverage = beverage; 
        }
        public override string GetDesc()
        {
            return _beverage.GetDesc() + " + Chocolate";
        }

        public override decimal GetPrice()
        {
            return _beverage.GetPrice() + 0.50M ;
        }
    }
}
