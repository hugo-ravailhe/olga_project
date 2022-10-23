using System.Runtime.CompilerServices;

namespace PizzaController;

public class Clerk : Person
{
    
    //*********** Constructor ***********
    public Clerk(string firstname, string name) : base(firstname, name){}

    //*********** Methods ***********
    public Customer CreateCustomerAccount()
    {
        Console.WriteLine("Please enter the client's information :");
        Console.WriteLine("-- Firstname :");
        string firstname = Console.ReadLine();
        Console.WriteLine("-- Lastname :");
        string lastname = Console.ReadLine();
        Console.WriteLine("-- Phone number :");
        string phone = Console.ReadLine();
        Console.WriteLine("-- Address :");
        string address = Console.ReadLine();

        return new Customer(firstname, lastname, phone, address);
    }
    
    public void ModifyCustomerAccount(Customer c)
    {
        int choice = 0;
        do
        {
            Console.WriteLine("Please select the client's information that you want to change :");
            Console.WriteLine("-1- Name");
            Console.WriteLine("-2- Phone number");
            Console.WriteLine("-3- Address");
            Console.WriteLine("-0- To exit");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the new client firstname :");
                    c.Firstname = Console.ReadLine();
                    Console.WriteLine("Enter the new client lastname :");
                    c.Lastname = Console.ReadLine();
                    Console.WriteLine(c.Firstname + " " + c.Lastname + "'s information has been changed\n\n");
                    break;
                case 2:
                    Console.WriteLine("Enter the new phone number :");
                    c.Phone = Console.ReadLine();
                    Console.WriteLine(c.Firstname + " " + c.Lastname + "'s information has been changed\n\n");
                    break;
                case 3:
                    Console.WriteLine("Enter the new address :");
                    c.Address = Console.ReadLine();
                    Console.WriteLine(c.Firstname + " " + c.Lastname + "'s information has been changed\n\n");
                    break;
                default:
                    if (choice != 0)
                    {
                        Console.WriteLine("Wrong choice, try another number !!!\n\n");
                    }
                    break;
            }
        } while (choice != 0);
        Console.WriteLine(c.Firstname + " " + c.Lastname + "'s information :");
        Console.WriteLine("Phone number : " + c.Phone);
        Console.WriteLine("Address : " + c.Address);
    }

    public Order CreateOrder(Customer c)
    {
        int choice = 0;
        Order order = new Order(c, this);
        
        do
        {
            Console.WriteLine("Please select your item :\n" +
                              "-1- Pizza menu\n" +
                              "-2- Drink menu\n");
            choice = Int32.Parse(Console.ReadLine());
            int num = 0;
            switch (choice)
            {
                case 1: // Pizza Choice
                    Pizza pizza;
                    int pizzaChoice;
                    int pizzaSizeChoice;

                    Console.WriteLine("Please select your pizza :\n" +
                                      "-1- Pepperoni\n" +
                                      "-2- Four Cheese\n" +
                                      "-3- Raclette\n" +
                                      "-4- Cannibale\n" +
                                      "-0- To exit this menu\n");
                    pizzaChoice = Int32.Parse(Console.ReadLine());

                    if (pizzaChoice > 0 || pizzaChoice <= 4)
                    {
                        Console.WriteLine("Please select the pizza size :\n" +
                                          "-1- M\n" +
                                          "-2- L\n" +
                                          "-3- XL\n");
                        pizzaSizeChoice = Int32.Parse(Console.ReadLine());
                        if (pizzaSizeChoice > 0 || pizzaSizeChoice <= 3)
                        {
                            Console.WriteLine("Please select how many pizza you want :");
                            num = Int32.Parse(Console.ReadLine());
                            pizza = new Pizza(pizzaChoice, pizzaSizeChoice);

                            for (int i = 0; i < num; i++)
                            {
                                order.Items.Add(pizza);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong choice");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice");
                    }
                    break;
                case 2:
                    Drink drink;
                    int drinkChoice;
                    int drinkSizeChoice;

                    Console.WriteLine("Please select your drink :\n" +
                                      "-1- Pepsi\n" +
                                      "-2- Orangina\n" +
                                      "-3- SevenUp\n" +
                                      "-4- Water\n" +
                                      "-0- To exit this menu\n");
                    drinkChoice = Int32.Parse(Console.ReadLine());

                    if (drinkChoice > 0 || drinkChoice <= 4)
                    {
                        Console.WriteLine("Please select the drink size :\n" +
                                          "-1- M\n" +
                                          "-2- L\n" +
                                          "-3- XL\n");
                        drinkSizeChoice = Int32.Parse(Console.ReadLine());
                        if (drinkSizeChoice > 0 || drinkSizeChoice <= 3)
                        {
                            Console.WriteLine("Please select how many drink you want :");
                            num = Int32.Parse(Console.ReadLine());
                            drink = new Drink(drinkChoice, drinkSizeChoice);

                            for (int i = 0; i < num; i++)
                            {
                                order.Items.Add(drink);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong choice");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong choice, try again");
                    break;
            }
        } while (choice != 0);

        Console.WriteLine("Order n°" + order.Id + "is completed, now it can be cook");
        return order;
    }
    
    
    
    
    
}