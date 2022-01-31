namespace BeverageApp
{
    public class HouseBlend : Beverage
    {
        public override string Description { get; set; } = "House blend";

        public override decimal Cost()
        {
            return .89m;
        }
    }
}
