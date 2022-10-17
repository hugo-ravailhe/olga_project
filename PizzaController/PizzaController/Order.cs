using System.Runtime.CompilerServices;

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
    private int _id;
    private string _hour;
    private string _date;
    private State _state;
    private Collection _collection;
    private Item[] _items;

    public Order(int id, string hour, string date, State state, Collection collection)
    {
        _id = id;
        _hour = hour;
        _date = date;
        _state = State.Making;
        _collection = Collection.InProgress;
        
    }

    public int Id { get; set; }
    public string Hour { get; set; }
    public string Date { get; set; }
    public State State { get; set; }
    public Collection Collection { get; set; }
    public Item[] Items { get; set; }
    
    
    
}