namespace PizzaController;

//******** Pizza Enumeration ********
public enum PizzaName
{
    Pepperoni = 9,
    FourCheese = 2,
    Raclette = 6,
    Cannibale = 7
}

public enum PizzaSize
{
    M = 0,
    L = 2,
    XL = 4,
}

public enum PizzaState
{
    Nothing,
    Cooking,
    Cooked
}

//******** Pizza Enumeration ********
public enum DrinkName
{
    Pepsi = 2,
    Orangina = 2,
    SevenUp = 2,
    Water = 1
}

public enum DrinkSize
{
    M = 0, //33cl
    L = 1, //50cl
    XL = 2, //1L
}

// ******** Class ********
public class Item
{
    //******** Attribut ********
    private double _price;
    

    //******** Constructor ********
    public Item(double price)
    {
        _price = price;
    }
    
    public Item() {}


    //******** Getter Setter ********
    public double Price { get; set; }
    
    
    //******** Methods ********
    public virtual void PriceCalculation() {}
}

public class Pizza : Item
{
    //******** Attribut ********
    private PizzaName _name;
    private PizzaSize _size;
    private PizzaState _state;
    

    //******** Constructor ********
    public Pizza(int idName, int idSize)
    {
        switch (idName)
        {
            case 1:
                _name = PizzaName.Pepperoni;
                break;
            case 2:
                _name = PizzaName.FourCheese;
                break;
            case 3:
                _name = PizzaName.Raclette;
                break;
            case 4:
                _name = PizzaName.Cannibale;
                break;
        }
        
        switch (idSize)
        {
            case 1:
                _size = PizzaSize.M;
                break;
            case 2:
                _size = PizzaSize.L;
                break;
            case 3:
                _size = PizzaSize.XL;
                break;
        }
        
        _state = PizzaState.Nothing;
        this.PriceCalculation();
    }

    public Pizza(PizzaName name, PizzaSize size) 
        : base(Convert.ToDouble(name) + Convert.ToDouble(size))
    {
        _name = name;
        _size = size;
    }
    
    
    //******** Getter Setter ********
    public PizzaName Name
    {
        get { return _name; }
        set { this._name = value; }
    }
    public PizzaSize Size 
    {
        get { return _size; }
        set { this._size = value; }
    }
    public PizzaState State 
    {
        get { return _state; }
        set { this._state = value; }
    }
    
    
    //******** Methods ********
    public override void PriceCalculation()
    {
        this.Price = Convert.ToDouble(_name) + Convert.ToDouble(_size);
    }

    /*static Pizza PizzaChoice(int idName, int idSize)
    {
        PizzaName name = PizzaName.Cannibale;
        switch (idName)
        {
            case 1:
                name = PizzaName.Pepperoni;
                break;
            case 2:
                name = PizzaName.FourCheese;
                break;
            case 3:
                name = PizzaName.Raclette;
                break;
            case 4:
                name = PizzaName.Cannibale;
                break;
        }

        PizzaSize size = PizzaSize.M;
        switch (idSize)
        {
            case 1:
                size = PizzaSize.M;
                break;
            case 2:
                size = PizzaSize.L;
                break;
            case 3:
                size = PizzaSize.XL;
                break;
        }

        return new Pizza(name, size);
    }*/
}

public class Drink : Item
{
    //******** Attribut ********
    private DrinkName _name;
    private DrinkSize _size;
    

    //******** Constructor ********
    public Drink(DrinkName name, DrinkSize size) 
        : base(Convert.ToDouble(name) + Convert.ToDouble(size))
    {
        
    }

    public Drink(int idName, int idSize)
    {
        switch (idName)
        {
            case 1:
                _name = DrinkName.Pepsi;
                break;
            case 2:
                _name = DrinkName.Orangina;
                break;
            case 3:
                _name = DrinkName.SevenUp;
                break;
            case 4:
                _name = DrinkName.Water;
                break;
        }
        
        switch (idSize)
        {
            case 1:
                _size = DrinkSize.M;
                break;
            case 2:
                _size = DrinkSize.L;
                break;
            case 3:
                _size = DrinkSize.XL;
                break;
        }
        
        this.PriceCalculation();
    }
    
    //******** Getter Setter ********
    public DrinkName Name { get; set; }
    public DrinkSize Size { get; set; }
    
    //******** Methods ********
    public override void PriceCalculation()
    {
        this.Price = Convert.ToDouble(_name) + Convert.ToDouble(_size);
    }
}