// See https://aka.ms/new-console-template for more information

namespace PizzaController;

public class Program
{
    static void Main(string[] args)
    {

        List<Clerk> clerks = new List<Clerk>();
        List<Cook> cooks = new List<Cook>();
        List<DeliveryMan> deliveryMen = new List<DeliveryMan>();
        List<Customer> customers = new List<Customer>();
        List<Order> orders = new List<Order>();

        clerks.Add(new Clerk("Arnaud", "Teillet"));
        cooks.Add(new Cook("Benjamin", "Liszewski"));
        deliveryMen.Add(new DeliveryMan("Julien","Mabecque"));

        int choice = 0;
        do
        {
            Console.WriteLine("Please select a menu :\n" +
                              "-1- Create an order\n" +
                              "-2- Customer menu");
            choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int choice2 = 0;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please select an action :\n" +
                                      "-1- Find a customer by its name\n" +
                                      "-2- Find a customer by tis phone number\n" +
                                      "-3- Create a new customer account");
                    choice2 = Int32.Parse(Console.ReadLine());
                    Customer customer = null;
                    if (choice2 == 1)
                    {
                        Console.WriteLine("Select the customer's firstname and lastname :");
                        customer = clerks[0].FindCustomerByName(Console.ReadLine(), Console.ReadLine(), customers);
                    }

                    if (choice2 == 2)
                    {
                        Console.WriteLine("Select the customer's phone number");
                        customer = clerks[0].FindCustomerByPhone(Console.ReadLine(), customers);
                    }

                    if (choice2 == 3 || customer == null)
                    {
                        Console.WriteLine("\n");
                        customer = clerks[0].CreateCustomerAccount();
                    }

                    Console.WriteLine("\n");
                    Order order = clerks[0].CreateOrder(customer);
                    
                    
                    CookAndDelivery(cooks[0], deliveryMen[0], order);
                    
                    orders.Add(order);
                    break;

            }
        } while (choice != 0);
        // Display the number of command line arguments.
        /*Clerk clerk1 = new Clerk("Arnaud", "Teillet");
        Customer customer1 = new Customer("Elisa", "Teillet", "0695516560", "Rue de la napolitaine");
        Customer customer2 = clerk1.CreateCustomerAccount();
        Cook cook1 = new Cook("Benjamin", "Liszewski");
        Console.WriteLine("Cook part:");
        cook1.CookOrder(order);
        Thread.Sleep(16000);
        Console.WriteLine(order.DateTime);*/
    }

    public static async void CookAndDelivery(Cook cook, DeliveryMan deliveryMan, Order order)
    {
        await cook.CookOrder(order);
        await deliveryMan.Delivery(order);
    }
}