namespace PizzaController;

public class DeliveryMan : Person
{
    //******** Constructor ********
    public DeliveryMan(string firstname, string name) : base(firstname, name){}
    
    //******** Methods ********
    public async Task Delivery(Order order)
    {
        order.State = State.Delivery;
        
        Console.WriteLine("Customer address is " + order.Customer.Address + " and it's order n°" + order.Id);
        
        await Task.Delay(4000);
        
        Console.WriteLine("Order n°" + order.Id + " is delivered");

        order.State = State.Finished;
        order.Collection = Collection.Collected;
        
        /*Console.WriteLine("Does the customer paid ? (y/n)");

        string choice = Console.ReadLine();

        if (choice == "y")
        {
            order.Collection = Collection.Collected;
        }
        else
        {
            order.Collection = Collection.Lost;
        }*/
        
    }
    
}

public class Bill
{
    private Boolean _paid;
    private double _price;
    private Order _order;

    public Bill(Order order)
    {
        this._paid = true;
        this._order = order;
        this._price = order.Price;
    }
}