namespace BeverageApp.Condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        public override string Description { get; set; } = " + Steamed milk";

        public SteamedMilk(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + .10m;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + Description;
        }
    }
}
