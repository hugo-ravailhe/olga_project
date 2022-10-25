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
        List<Bill> bills = new List<Bill>();

        clerks.Add(new Clerk("Arnaud", "Teillet"));
        cooks.Add(new Cook("Benjamin", "Liszewski"));
        deliveryMen.Add(new DeliveryMan("Julien","Mabecque"));

        int choice = 0;
        do
        {
            Console.WriteLine("Please select a menu :\n" +
                              "-1- Create an order\n" +
                              "-2- Customer menu\n" +
                              "-3- Show Orders");
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
                        customers.Add(customer);
                    }
                    
                    Console.WriteLine("\n");
                    Order order = clerks[0].CreateOrder(customer);
                    
                    
                    CookAndDelivery(cooks[0], deliveryMen[0], order, bills);
                    
                    orders.Add(order);
                    break;
                case 2:
                    Console.WriteLine("Please select an action :\n" +
                                      "-1- Find a customer by its name\n" +
                                      "-2- Find a customer by tis phone number\n" +
                                      "-3- Create a new customer account");
                    choice2 = Int32.Parse(Console.ReadLine());
                    if (choice2 == 3)
                    {
                        customer = clerks[0].CreateCustomerAccount();
                        customers.Add(customer);
                    }
                    else
                    {
                        if (choice2 == 1)
                        {
                            Console.WriteLine("Select the customer's firstname and lastname :");
                            customer = clerks[0].FindCustomerByName(Console.ReadLine(), Console.ReadLine(), customers);
                            clerks[0].ModifyCustomerAccount(customer);
                        }

                        if (choice2 == 2)
                        {
                            Console.WriteLine("Select the customer's phone number");
                            customer = clerks[0].FindCustomerByPhone(Console.ReadLine(), customers);
                            clerks[0].ModifyCustomerAccount(customer);
                        }
                    }
                    break;
                case 3:
                    ShowOrder(orders);
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

    public static async void CookAndDelivery(Cook cook, DeliveryMan deliveryMan, Order order, List<Bill> bills)
    {
        await cook.CookOrder(order);
        await deliveryMan.Delivery(order);
        bills.Add(new Bill(order));
    }

    public static void ShowOrder(List<Order> orders)
    {
        Console.WriteLine("*******Order******* ");
        foreach (Order vOrder in orders)
        {
            Console.WriteLine("---- Order n°" + vOrder.Id + " ----\n" +
                              "- Price : " + vOrder.Price + "\n" +
                              "- State : " + vOrder.State + "\n" +
                              "- Date : " + vOrder.DateTime + "\n");

            if (vOrder.Pizzas.Count != 0)
            {
                foreach (Pizza variablePizza in vOrder.Pizzas)
                {
                    Console.WriteLine("---- Pizza ----\n" +
                                      "Name : " + variablePizza.Name + "\n" +
                                      "Size : " + variablePizza.Size + "\n" +
                                      "State : " + variablePizza.State + "\n" +
                                      "Price : " + variablePizza.Price + "€\n");
                }
            }

            if (vOrder.Drinks.Count != 0)
            {
                foreach (Drink variabDrink in vOrder.Drinks)
                {
                    Console.WriteLine("---- Drink ----\n" +
                                      "Name : " + variabDrink.Name + "\n" +
                                      "Size : " + variabDrink.Size + "\n" +
                                      "Price : " + variabDrink.Price + "€\n\n");
                }
            }
        }
    } 
}