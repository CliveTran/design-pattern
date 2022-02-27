namespace PizzaStore.PizzaIngredients.Factories
{
    public class ChicagoPizzaIngredientFactory : IngredientFactory
    {
        public override void CreateCheese()
        {
            Console.WriteLine("Chicago Cheese added!");
        }

        public override void CreateClam()
        {
            Console.WriteLine("Chicago Clam added!");
        }

        public override void CreateDough()
        {
            Console.WriteLine("Chicago Dough added!");
        }

        public override void CreatePepperoni()
        {
            Console.WriteLine("Chicago Pepperoni added!");
        }

        public override void CreateSauce()
        {
            Console.WriteLine("Chicago Sauce added!");
        }

        public override void CreateVeggies()
        {
            Console.WriteLine("Chicago Veggies added!");
        }
    }
}
