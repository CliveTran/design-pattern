using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.CaliforniaStyles
{
    public class CaliforniaStyleCheesePizza : Pizza
    {
        public CaliforniaStyleCheesePizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreateCheese();
            Console.WriteLine($"{nameof(CaliforniaStyleCheesePizza)} Pizza completed!");
        }
    }
}
