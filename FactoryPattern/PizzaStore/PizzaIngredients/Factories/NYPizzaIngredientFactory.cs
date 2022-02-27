using PizzaStore.PizzaIngredients.Ingredients;

namespace PizzaStore.PizzaIngredients.Factories
{
    public class NYPizzaIngredientFactory : IngredientFactory
    {
        public override NYCheese CreateCheese()
        {
            Console.WriteLine("NY Cheese added!");
            return new NYCheese();
        }

        public override NYClam CreateClam()
        {
            Console.WriteLine("NY Clam added!");
            return new NYClam();
        }

        public override NYPepperoni CreatePepperoni()
        {
            Console.WriteLine("NY Pepperoni added!");
            return new NYPepperoni();
        }

        public override NYVeggie CreateVeggies()
        {
            Console.WriteLine("NY Veggies added!");
            return new NYVeggie();
        }
    }
}
