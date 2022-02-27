using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.ChicagoStyles
{
    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreateClam();
            Console.WriteLine($"{nameof(ChicagoStyleClamPizza)} Pizza completed!");
        }
    }
}
