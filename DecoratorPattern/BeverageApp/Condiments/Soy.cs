namespace BeverageApp.Condiments
{
    public class Soy : CondimentDecorator
    {
        public override string Description { get; set; } = " + Soy";

        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + .15m;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + Description;
        }
    }
}
