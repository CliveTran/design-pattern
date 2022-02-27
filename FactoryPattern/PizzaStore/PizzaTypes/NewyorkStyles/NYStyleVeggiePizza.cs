using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.NewyorkStyles
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreateVeggies();
            Console.WriteLine($"{nameof(NYStyleVeggiePizza)} Pizza completed!");
        }
    }
}
