// See https://aka.ms/new-console-template for more information

namespace PizzaController;

public class Program
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine(args.Length);
        Order order = new Order();
        Console.WriteLine(order.Id);
    }
}