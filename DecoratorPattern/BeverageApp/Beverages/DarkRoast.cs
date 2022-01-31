namespace BeverageApp
{
    public class DarkRoast : Beverage
    {
        public override string Description { get; set; } = "Dark roast";

        public override decimal Cost()
        {
            return .99m;
        }
    }
}
