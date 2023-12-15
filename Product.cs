using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager_WinForm
{
    public class Product
    {
        public Product(string name, string description, double price)
        {

            Name = name;
            Description = description;
            Price = price;
        }

        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name}-{Description}-{Price}";
        }
    }
}
