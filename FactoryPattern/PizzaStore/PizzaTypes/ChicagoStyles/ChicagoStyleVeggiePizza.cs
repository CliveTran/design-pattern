using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.ChicagoStyles
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreateVeggies();
            Console.WriteLine($"{nameof(ChicagoStyleVeggiePizza)} Pizza completed!");
        }
    }
}
