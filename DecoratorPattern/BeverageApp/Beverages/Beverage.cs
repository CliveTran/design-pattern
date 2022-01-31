namespace BeverageApp
{
    public abstract class Beverage
    {
        public abstract string Description { get; set; }
        public abstract decimal Cost();
        public virtual string GetDescription()
        {
            return Description;
        }
    }
}
