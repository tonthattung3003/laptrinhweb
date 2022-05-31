using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class ShoppingBasket
    {
        public Customer customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = new List<int>();
        public void Add(int pizzaId)
            => Orders.Add(pizzaId);
        public bool Haspaid { get; set; }
        public void RemoveAt(int pos)
        => Orders.RemoveAt(pos);
    }
}
