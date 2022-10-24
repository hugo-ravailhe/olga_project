﻿using System.Runtime.CompilerServices;
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
    private List<Drink> _drinks;
    private List<Pizza> _pizzas;
    private Customer _customer;
    private Clerk _clerk;

    //******** Constructor ********
    public Order(Customer customer, Clerk clerk)
    {
        _id = _nextId;
        _dateTime = DateTime.Now;
        _state = State.Making;
        _collection = Collection.InProgress;
        _customer = customer;
        _clerk = clerk;
        _pizzas = new List<Pizza>();
        _drinks = new List<Drink>();
        _nextId++;
    }

    //******** Getter Setter ********
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public State State { get; set; }
    public Collection Collection { get; set; }
    public List<Drink> Drinks { get; set; }

    public List<Pizza> Pizzas
    {
        get { return this._pizzas; }
        set { this._pizzas = value; }
    }
    public Customer Customer
    {
        get { return _customer; }
        set { this._customer = value; }
    }
    public Clerk Clerk
    {
        get { return _clerk; }
        set { this._clerk = value; }
    }

    //******** Methods ********
    public Boolean OrderIsReady()
    {
        Boolean ready = true;
        foreach (Pizza item in Pizzas)
        {
            if (ready && item.GetType() == typeof(Pizza))
            {
                ready = (item.State == PizzaState.Cooked);
            }
        }

        return ready;
    }

    public void AddPizza(Pizza p)
    {
        _pizzas.Add(p);
    }

    public void AddDrink(Drink d)
    {
        _drinks.Add(d);
    }
}

