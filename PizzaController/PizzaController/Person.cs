namespace PizzaController;

public class Person
{
    private string _firstname;
    private string _lastname;

    public Person(string firstname, string lastname)
    {
        _firstname = firstname;
        _lastname = lastname;
    }
    
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    
}