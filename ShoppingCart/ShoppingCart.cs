using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ShoppingCart
    {
        public int CartId { get; set; }
        public List<Product> lstProducts { get; set; }
    }
}
