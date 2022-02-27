using PizzaStore.PizzaIngredients.Factories;
using PizzaStore.PizzaTypes;

namespace PizzaStore.PizzaStores
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string type, IngredientFactory ingredientFactory);
        public abstract void OrderPizza(string type);
    }
}
