using PizzaStore.PizzaIngredients.Factories;
using PizzaStore.PizzaTypes;
using PizzaStore.PizzaTypes.CaliforniaStyles;

namespace PizzaStore.PizzaStores
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type, IngredientFactory ingredientFactory)
        {
            return type.ToLower() switch
            {
                "cheese" => new CaliforniaStyleCheesePizza(ingredientFactory),
                "veggie" => new CaliforniaStyleVeggiePizza(ingredientFactory),
                "clam" => new CaliforniaStyleClamPizza(ingredientFactory),
                "pepperoni" => new CaliforniaStylePepperoniPizza(ingredientFactory),
                _ => throw new Exception("We don't have that kind of pizza."),
            };
        }

        public override void OrderPizza(string type)
        {
            Console.WriteLine("Message from CaliforniaPizzaStore: your order is being prepared!");
            var caliFactory = new CaliforniaPizzaIngredientFactory();
            var pizza = CreatePizza(type, caliFactory);
            Console.WriteLine("Your order from CaliforniaPizzaStore is completed!");
        }
    }
}
