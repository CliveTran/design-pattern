using PizzaStore.PizzaTypes;
using PizzaStore.PizzaTypes.CaliforniaStyles;

namespace PizzaStore.PizzaStores
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            return type.ToLower() switch
            {
                "cheese" => new CaliforniaStyleCheesePizza(),
                "veggie" => new CaliforniaStyleVeggiePizza(),
                "clam" => new CaliforniaStyleClamPizza(),
                "pepperoni" => new CaliforniaStylePepperoniPizza(),
                _ => throw new Exception("We don't have that kind of pizza."),
            };
        }
    }
}
