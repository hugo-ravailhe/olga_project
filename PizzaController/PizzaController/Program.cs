// See https://aka.ms/new-console-template for more information

namespace PizzaController;

public class Program
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Clerk clerk1 = new Clerk("Arnaud", "Teillet");
        Customer customer1 = new Customer("Elisa", "Teillet", "0695516560", "Rue de la napolitaine");
        Customer customer2 = clerk1.CreateCustomerAccount();
        Order order = clerk1.CreateOrder(customer2);
        Console.WriteLine(order.Id = 2);
        Console.WriteLine(order.DateTime);
    }
}