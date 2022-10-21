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
    M = 33, //33cl
    L = 50, //50cl
    XL = 100, //1L
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