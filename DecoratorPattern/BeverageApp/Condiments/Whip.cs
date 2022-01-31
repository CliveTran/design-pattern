namespace BeverageApp.Condiments
{
    public class Whip : CondimentDecorator
    {
        public override string Description { get; set; } = " + Whip";

        public Whip(Beverage beverage)
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
