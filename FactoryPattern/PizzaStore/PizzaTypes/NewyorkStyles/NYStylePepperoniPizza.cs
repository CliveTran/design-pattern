using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.NewyorkStyles
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreatePepperoni();
            Console.WriteLine($"{nameof(NYStylePepperoniPizza)} Pizza completed!");
        }
    }
}
