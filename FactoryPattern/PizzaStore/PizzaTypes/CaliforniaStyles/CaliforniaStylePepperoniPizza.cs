using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.CaliforniaStyles
{
    public class CaliforniaStylePepperoniPizza : Pizza
    {
        public CaliforniaStylePepperoniPizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreatePepperoni();
            Console.WriteLine($"{nameof(CaliforniaStylePepperoniPizza)} Pizza completed!");
        }
    }
}
