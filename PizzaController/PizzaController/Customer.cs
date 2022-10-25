namespace PizzaController;

public class Customer : Person
{
    private int _nextId = 1;
    private int _id;
    private string _phone;
    private string _address;
    private List<Order> _orders;

    public Customer(string firstname, string lastname, string phone, string address) 
        : base (lastname, firstname)
    {
        _id = _nextId;
        this._phone = phone;
        this._address = address;
    }
    
    public int Id { get; set; }
    public string Phone 
    {
        get { return this._phone; }
        set { this._phone = value; }
    }
    public string Address
    {
        get { return this._address; }
        set { this._address = value; }
    }
    public List<Order> Orders 
    {
        get { return this._orders; }
        set { this._orders = value; }
    }

}