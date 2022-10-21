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
        int phone = Int32.Parse(Console.ReadLine());
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
                    Console.WriteLine(c.Firstname + " " + c.Lastname + "'s information has been changed");
                    break;
                case 2:
                    Console.WriteLine("Enter the new phone number :");
                    c.Phone = Int32.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Enter the new address :");
                    c.Address = Console.ReadLine();
                    break;
                default:
                    if (choice != 0)
                    {
                        Console.WriteLine("Wrong choice, try another number !!!");
                    }
                    break;
            }
        } while (choice != 0);
        Console.WriteLine(c.Firstname + " " + c.Lastname + "'s information :");
        Console.WriteLine("Phone number : " + c.Phone);
        Console.WriteLine("Address : " + c.Address);
    }
}