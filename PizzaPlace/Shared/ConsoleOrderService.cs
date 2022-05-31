using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class ConsoleOrderService : IOderService
    {
        public ValueTask PlaceOrder(ShoppingBasket basket)
        {
            Console.WriteLine($"Placing order for {basket.customer.Name}");
            return new ValueTask();    
        }

    }
}
