using System.Linq;

namespace HostedTest.Shared
{
    public class State
    {
        public Basket Basket {get; set;} = new Basket();

        public Menu Menu {get; set;} = new Menu();

        public UI UI {get; set;} = new UI();

        public decimal TotalPrice => Basket.Orders.Sum(id => Menu.GetPizza(id).Price);
    }
}