using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public string SKUId { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public int GetPrice(Product p)
        {
            int total = 0;
            total = p.Quantity * p.Price;

            return total;
        }

        public virtual int ApplyPromotion(List<Product> prod)
        {
            return 0;
        }

    }
}
