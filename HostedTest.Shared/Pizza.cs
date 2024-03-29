using System;

namespace HostedTest.Shared
{
public enum Spiciness 
{
    None,
    Spicy,
    Hot
}

public class Pizza
{
    public Pizza(int id, string name, decimal price, Spiciness spiciness)
    {
        Id = id;
        Name = name ?? throw new ArgumentNullException("A pizza needs a name!");
        Price = price;
        Spiciness = spiciness;

    }

    public int Id {get;}
    public string Name {get;}
    public decimal Price {get;}
    public Spiciness Spiciness {get;}
}

}