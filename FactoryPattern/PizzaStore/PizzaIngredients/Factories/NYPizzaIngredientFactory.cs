namespace PizzaStore.PizzaIngredients.Factories
{
    public class NYPizzaIngredientFactory : IngredientFactory
    {
        public override void CreateCheese()
        {
            Console.WriteLine("NY Cheese added!");
        }

        public override void CreateClam()
        {
            Console.WriteLine("NY Clam added!");
        }

        public override void CreateDough()
        {
            Console.WriteLine("NY Dough added!");
        }

        public override void CreatePepperoni()
        {
            Console.WriteLine("NY Pepperoni added!");
        }

        public override void CreateSauce()
        {
            Console.WriteLine("NY Sauce added!");
        }

        public override void CreateVeggies()
        {
            Console.WriteLine("NY Veggies added!");
        }
    }
}
