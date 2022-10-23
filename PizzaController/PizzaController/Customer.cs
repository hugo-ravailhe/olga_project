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
    public string Phone { get; set; }
    public string Address { get; set; }
    public List<Order> Orders { get; set; }

}