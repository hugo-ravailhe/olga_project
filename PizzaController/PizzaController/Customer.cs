namespace PizzaController;

public class Customer: Person
{
    private int _nextId = 1;
    private int _id;
    private int _phone;
    private string _address;

    public Customer(int phone, string address)
    {
        _id = _nextId;
        this._address = address;
        this._phone = phone;
    }
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int Phone { get; set; }
    public string Address { get; set; }

}