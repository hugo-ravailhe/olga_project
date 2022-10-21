using System.Runtime.CompilerServices;
using System;

namespace PizzaController;

public enum Collection
{
    InProgress,
    Collected,
    Lost
}
    
public enum State
{
    Making,
    Delivery,
    Finished
}
public class Order
{

    private int _nextId = 1;
    private int _id;
    private DateTime  _dateTime;
    private State _state;
    private Collection _collection;
    private Item[] _items;
    private Customer _customer;
    private Clerk _clerk;

    public Order(Customer customer, Clerk clerk)
    {
        _id = _nextId;
        _dateTime = DateTime.Today;
        _state = State.Making;
        _collection = Collection.InProgress;
        _customer = customer;
        _clerk = clerk;
        _nextId++;
    }

    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public State State { get; set; }
    public Collection Collection { get; set; }
    public Item[] Items { get; set; }
    
    
}

