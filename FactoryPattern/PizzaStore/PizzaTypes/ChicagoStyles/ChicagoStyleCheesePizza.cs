using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.ChicagoStyles
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreateCheese();
            Console.WriteLine($"{nameof(ChicagoStyleCheesePizza)} Pizza completed!");
        }
    }
}
