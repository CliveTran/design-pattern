namespace PizzaStore.PizzaIngredients.Factories
{
    public class CaliforniaPizzaIngredientFactory : IngredientFactory
    {
        public override void CreateCheese()
        {
            Console.WriteLine("California Cheese added!");
        }

        public override void CreateClam()
        {
            Console.WriteLine("California Clam added!");
        }

        public override void CreateDough()
        {
            Console.WriteLine("California Dough added!");
        }

        public override void CreatePepperoni()
        {
            Console.WriteLine("California Pepperoni added!");
        }

        public override void CreateSauce()
        {
            Console.WriteLine("California Sauce added!");
        }

        public override void CreateVeggies()
        {
            Console.WriteLine("California Veggies added!");
        }
    }
}
