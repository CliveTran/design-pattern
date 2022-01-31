using PizzaStore.PizzaTypes;

namespace PizzaStore.PizzaStores
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string type);
        public void OrderPizza(string type)
        {
            var pizza = CreatePizza(type);
            Console.WriteLine($"Your order ({pizza.GetType().Name}) has been created.");
        }
    }
}
