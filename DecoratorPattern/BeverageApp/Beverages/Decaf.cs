namespace BeverageApp
{
    public class Decaf : Beverage
    {
        public override string Description { get; set; } = "Decaf";

        public override decimal Cost()
        {
            return 1.05m;
        }
    }
}
