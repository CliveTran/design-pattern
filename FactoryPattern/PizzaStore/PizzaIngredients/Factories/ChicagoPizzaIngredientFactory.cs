using PizzaStore.PizzaIngredients.Ingredients;

namespace PizzaStore.PizzaIngredients.Factories
{
    public class ChicagoPizzaIngredientFactory : IngredientFactory
    {
        public override ChicagoCheese CreateCheese()
        {
            Console.WriteLine("Chicago Cheese added!");
            return new ChicagoCheese();
        }

        public override ChicagoClam CreateClam()
        {
            Console.WriteLine("Chicago Clam added!");
            return new ChicagoClam();
        }

        public override ChicagoPepperoni CreatePepperoni()
        {
            Console.WriteLine("Chicago Pepperoni added!");
            return new ChicagoPepperoni();
        }

        public override ChicagoVeggie CreateVeggies()
        {
            Console.WriteLine("Chicago Veggies added!");
            return new ChicagoVeggie();
        }
    }
}
