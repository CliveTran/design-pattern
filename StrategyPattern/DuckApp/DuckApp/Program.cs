// See https://aka.ms/new-console-template for more information

var duck = new MallardDuck();
duck.PerformFly(); // "Flying..."
duck.PerformQuack(); // "Quack quack quack!!!"
duck.SetFly(new CannotFly()); // Can be changed => flexibility
duck.PerformFly(); // "Can't fly bro."

Console.ReadKey();

public abstract class Duck
{
    protected IFlyBehaviour? FlyBehaviour { get; set; } // Program to an interface, not an implementation => Loose coupling
    protected IQuackBehaviour? QuackBehaviour { get; set; } // Program to an interface, not an implementation => Loose coupling

    public void PerformFly()
    {
        FlyBehaviour?.Fly();
    }

    public void PerformQuack()
    {
        QuackBehaviour?.MakeNoises();
    }

    // Make it interchangeable even in compiled time
    public void SetFly(IFlyBehaviour flyBehaviour)
    {
        FlyBehaviour = flyBehaviour;
    }

    // Make it interchangeable even in compiled time
    public void SetQuack(IQuackBehaviour quackBehaviour)
    {
        QuackBehaviour = quackBehaviour;
    }
}

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        FlyBehaviour = new FlyWithWings();
        QuackBehaviour = new Quack();
    }
}

#region Strategy #1: Encapsulate fly algorythms
public interface IFlyBehaviour
{
    void Fly();
}

public class CannotFly : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("Can't fly bro.");
    }
}

public class FlyWithWings : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("Flying...");
    }
}
#endregion

#region Strategy #2: Encapsulate quack algorythms
public interface IQuackBehaviour
{
    void MakeNoises();
}

public class Quack : IQuackBehaviour
{
    public void MakeNoises()
    {
        Console.WriteLine("Quack quack quack!!!");
    }
}

public class Squeak : IQuackBehaviour
{
    public void MakeNoises()
    {
        Console.WriteLine("Squeak squeak squeak!!!");
    }
}
#endregion