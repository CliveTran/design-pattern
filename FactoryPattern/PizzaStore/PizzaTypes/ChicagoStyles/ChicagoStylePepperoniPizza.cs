using PizzaStore.PizzaIngredients.Factories;

namespace PizzaStore.PizzaTypes.ChicagoStyles
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza(IngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            ingredientFactory.CreatePepperoni();
            Console.WriteLine($"{nameof(ChicagoStylePepperoniPizza)} Pizza completed!");
        }
    }
}
