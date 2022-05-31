using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class Pizza
    {
        public Pizza(int id, string name, decimal price, Spiciness spiceness)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Spiciness = spiceness;
        }
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public Spiciness Spiciness { get; }
    }
}
