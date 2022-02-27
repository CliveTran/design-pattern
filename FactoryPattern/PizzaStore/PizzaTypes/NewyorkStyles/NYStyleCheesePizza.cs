using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.NewyorkStyles
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreateCheese();
            Console.WriteLine($"{nameof(NYStyleCheesePizza)} Pizza completed!");
        }
    }
}
