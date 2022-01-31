using PizzaStore.PizzaTypes;
using PizzaStore.PizzaTypes.NewyorkStyles;

namespace PizzaStore.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            return type.ToLower() switch
            {
                "cheese" => new NYStyleCheesePizza(),
                "veggie" => new NYStyleVeggiePizza(),
                "clam" => new NYStyleClamPizza(),
                "pepperoni" => new NYStylePepperoniPizza(),
                _ => throw new Exception("We don't have that kind of pizza."),
            };
        }
    }
}
