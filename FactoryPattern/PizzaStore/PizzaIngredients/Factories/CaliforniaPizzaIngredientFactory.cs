using PizzaStore.PizzaIngredients.Ingredients;

namespace PizzaStore.PizzaIngredients.Factories
{
    public class CaliforniaPizzaIngredientFactory : IngredientFactory
    {
        public override CaliforniaCheese CreateCheese()
        {
            Console.WriteLine("California Cheese added!");
            return new CaliforniaCheese();
        }

        public override CaliforniaClam CreateClam()
        {
            Console.WriteLine("California Clam added!");
            return new CaliforniaClam();
        }

        public override CaliforniaPepperoni CreatePepperoni()
        {
            Console.WriteLine("California Pepperoni added!");
            return new CaliforniaPepperoni();
        }

        public override CaliforniaVeggie CreateVeggies()
        {
            Console.WriteLine("California Veggies added!");
            return new CaliforniaVeggie();
        }
    }
}
