using PizzaStore.PizzaIngredients.Factories;
using PizzaStore.PizzaTypes;
using PizzaStore.PizzaTypes.NewyorkStyles;

namespace PizzaStore.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type, IngredientFactory ingredientFactory)
        {
            return type.ToLower() switch
            {
                "cheese" => new NYStyleCheesePizza(ingredientFactory),
                "veggie" => new NYStyleVeggiePizza(ingredientFactory),
                "clam" => new NYStyleClamPizza(ingredientFactory),
                "pepperoni" => new NYStylePepperoniPizza(ingredientFactory),
                _ => throw new Exception("We don't have that kind of pizza."),
            };
        }

        public override void OrderPizza(string type)
        {
            var nyFactory = new NYPizzaIngredientFactory();
            var pizza = CreatePizza(type, nyFactory);
            Console.WriteLine("Your order from NYPizzaStore is completed!");
        }
    }
}
