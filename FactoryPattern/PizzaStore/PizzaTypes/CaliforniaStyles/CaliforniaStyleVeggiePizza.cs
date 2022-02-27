using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.CaliforniaStyles
{
    public class CaliforniaStyleVeggiePizza : Pizza
    {
        public CaliforniaStyleVeggiePizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreateVeggies();
            Console.WriteLine($"{nameof(CaliforniaStyleVeggiePizza)} Pizza completed!");
        }
    }
}
