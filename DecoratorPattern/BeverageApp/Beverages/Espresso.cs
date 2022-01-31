namespace BeverageApp
{
    public class Espresso : Beverage
    {
        public override string Description { get; set; } = "Espresso";

        public override decimal Cost()
        {
            return 1.99m;
        }
    }
}
