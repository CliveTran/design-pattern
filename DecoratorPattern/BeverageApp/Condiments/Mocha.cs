namespace BeverageApp.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public override string Description { get; set; } = " + Mocha";

        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + 0.20m;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + Description;
        }
    }
}
