using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.CaliforniaStyles
{
    public class CaliforniaStyleClamPizza : Pizza
    {
        public CaliforniaStyleClamPizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreateClam();
            Console.WriteLine($"{nameof(CaliforniaStyleClamPizza)} Pizza completed!");
        }
    }
}
