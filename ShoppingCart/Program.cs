using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Case 1
            //List<Product> lstProducts = new List<Product>();
            //Product p1 = new ProductA() { SKUId = "A", Quantity = 1 };
            //Product p2 = new ProductB() { SKUId = "B", Quantity = 1 };
            //Product p3 = new ProductC() { SKUId = "C", Quantity = 1 };
            //lstProducts.Add(p1);
            //lstProducts.Add(p2);
            //lstProducts.Add(p3);

            //Case 2
            //List<Product> lstProducts = new List<Product>();
            //Product p1 = new ProductA() { SKUId = "A", Quantity = 5 };
            //Product p2 = new ProductB() { SKUId = "B", Quantity = 5 };
            //Product p3 = new ProductC() { SKUId = "C", Quantity = 1 };
            //lstProducts.Add(p1);
            //lstProducts.Add(p2);
            //lstProducts.Add(p3);

            //Case 3
            //List<Product> lstProducts = new List<Product>();
            //Product p1 = new ProductA() { SKUId = "A", Quantity = 3 };
            //Product p2 = new ProductB() { SKUId = "B", Quantity = 5 };
            //Product p3 = new ProductC() { SKUId = "C", Quantity = 1 };
            //Product p4 = new ProductD() { SKUId = "D", Quantity = 1 };

            //lstProducts.Add(p1);
            //lstProducts.Add(p2);
            //lstProducts.Add(p3);
            //lstProducts.Add(p4);

            //Case 4
            List<Product> lstProducts = new List<Product>();
            Product p1 = new ProductA() { SKUId = "A", Quantity = 1 };
            Product p2 = new ProductB() { SKUId = "B", Quantity = 1 };
            Product p4 = new ProductD() { SKUId = "D", Quantity = 1 };

            lstProducts.Add(p1);
            lstProducts.Add(p2);
            lstProducts.Add(p4);

            ShoppingCart cart = new ShoppingCart();
            cart.CartId = 100;
            cart.lstProducts = lstProducts;

            Order o1 = new Order();
            o1.OrderId = 1;
            o1.OrderDate = DateTime.Now;
            o1.Cart = cart;

            var promotionEngine = new PromotionEngine();
            promotionEngine.Promote(o1.Cart);

        }
    }
}
