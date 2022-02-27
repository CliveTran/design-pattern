using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.NewyorkStyles
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreateClam();
            Console.WriteLine($"{nameof(NYStyleClamPizza)} Pizza completed!");
        }
    }
}
