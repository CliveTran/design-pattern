using PizzaStore.PizzaTypes;
using PizzaStore.PizzaTypes.ChicagoStyles;

namespace PizzaStore.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            return type.ToLower() switch
            {
                "cheese" => new ChicagoStyleCheesePizza(),
                "veggie" => new ChicagoStyleVeggiePizza(),
                "clam" => new ChicagoStyleClamPizza(),
                "pepperoni" => new ChicagoStylePepperoniPizza(),
                _ => throw new Exception("We don't have that kind of pizza."),
            };
        }
    }
}
