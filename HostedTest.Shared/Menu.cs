using System.Collections.Generic;
using System.Linq;

namespace HostedTest.Shared
{
public class Menu
{
    public List<Pizza> Pizzas {get; set; } = new List<Pizza>();

    public Pizza GetPizza(int id) => Pizzas.FirstOrDefault(pizza => pizza.Id == id);
}
}