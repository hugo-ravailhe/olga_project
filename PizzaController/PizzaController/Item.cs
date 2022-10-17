namespace PizzaController;

public enum PizzaSize
{
    M,
    L,
    XL,
}

public enum DrinkName
{
    Pepsi,
    Orangina,
    SevenUp
}

public enum DrinkSize
{
    
}
public abstract class Item
{
    private double _price;
    
    public double Price { get; set; }
}

public class Pizza : Item
{
    
}

public class Drink : Item
{
    
}