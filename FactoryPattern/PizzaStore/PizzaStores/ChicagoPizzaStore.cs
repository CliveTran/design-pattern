using PizzaStore.PizzaIngredients.Factories;
using PizzaStore.PizzaTypes;
using PizzaStore.PizzaTypes.ChicagoStyles;

namespace PizzaStore.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type, IngredientFactory ingredientFactory)
        {
            return type.ToLower() switch
            {
                "cheese" => new ChicagoStyleCheesePizza(ingredientFactory),
                "veggie" => new ChicagoStyleVeggiePizza(ingredientFactory),
                "clam" => new ChicagoStyleClamPizza(ingredientFactory),
                "pepperoni" => new ChicagoStylePepperoniPizza(ingredientFactory),
                _ => throw new Exception("We don't have that kind of pizza."),
            };
        }

        public override void OrderPizza(string type)
        {
            Console.WriteLine("Message from ChicagoPizzaStore: your order is being prepared!");
            var chicagoFactory = new ChicagoPizzaIngredientFactory();
            var pizza = CreatePizza(type, chicagoFactory);
            Console.WriteLine("Your order from ChicagoPizzaStore is completed!");
        }
    }
}
