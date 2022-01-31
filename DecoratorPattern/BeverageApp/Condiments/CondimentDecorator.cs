namespace BeverageApp
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage Beverage { get; set; }
    }
}
