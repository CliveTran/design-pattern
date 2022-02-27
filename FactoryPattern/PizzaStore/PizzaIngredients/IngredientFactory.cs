namespace PizzaStore.PizzaIngredients.Factories
{
    public abstract class IngredientFactory 
    {
        public abstract Ingredient CreateCheese();
        public abstract Ingredient CreateVeggies();
        public abstract Ingredient CreatePepperoni();
        public abstract Ingredient CreateClam();
    }
}
