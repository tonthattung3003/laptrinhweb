using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class State
    {
        public Menu menu { get; } = new Menu();
        public ShoppingBasket Basket { get; } = new ShoppingBasket();
        public UI UI { get; } = new UI();
        public decimal TotalPrice
            => Basket.Orders.Sum(Id => menu.GetPizza(Id)!.Price);
    }
}
