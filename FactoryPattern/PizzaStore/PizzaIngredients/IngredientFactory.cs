namespace PizzaStore.PizzaIngredients.Factories
{
    public abstract class IngredientFactory 
    {
        public abstract void CreateDough();
        public abstract void CreateSauce();
        public abstract void CreateCheese();
        public abstract void CreateVeggies();
        public abstract void CreatePepperoni();
        public abstract void CreateClam();
    }
}
