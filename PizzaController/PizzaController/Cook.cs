namespace PizzaController;

public class Cook : Person
{
    //******** Constructor ********
    public Cook(string firstname, string name) : base(firstname, name){}
    
    //******** Methods ********
    public async void CookPizza(Pizza p)
    {
        Console.WriteLine(p.Name + " is baking");
        p.State = PizzaState.Cooking;
        await Task.Delay(8000);
        p.State = PizzaState.Cooked;
        Console.WriteLine(p.Name + " is ready");
    }

    public async void CookOrder(Order order)
    {
        
    }
}