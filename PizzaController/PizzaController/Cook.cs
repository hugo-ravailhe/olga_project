namespace PizzaController;

public class Cook : Person
{
    //******** Constructor ********
    public Cook(string firstname, string name) : base(firstname, name){}
    
    //******** Methods ********
    public async Task CookPizza(Pizza p)
    {
        Console.WriteLine(p.Name + " is baking");
        p.State = PizzaState.Cooking;
        await Task.Delay(4000);
        p.State = PizzaState.Cooked;
        Console.WriteLine(p.Name + " is ready");
    }

    public async Task CookOrder(Order order)
    {
        Console.WriteLine("Let's go to cook");
        Boolean ready = false;
        do
        {
            foreach (Pizza item in order.Pizzas)
            {
                if (item.GetType() == typeof(Pizza) && item.State == PizzaState.Nothing)
                {
                    await CookPizza(item);
                }
            }

            ready = order.OrderIsReady();
        } while (!ready);
        Console.WriteLine("Order n°" + order.Id + " is ready.");
    }
}