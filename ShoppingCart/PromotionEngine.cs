using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class PromotionEngine
    {
        public int Promote(ShoppingCart cart)
        {
            int price = 0;
            int discount = 0;
            int totalPrice = 0;
            bool CounterofC = false;
            List<Product> lstProduct = new List<Product>();
            Product productC = new Product();

            Console.WriteLine("Promote Method");

            foreach (Product p in cart.lstProducts)
            {
                lstProduct.Add(p);

                if (p.SKUId == "C")
                {
                    CounterofC = true;
                    productC = p;
                }


                if (p.SKUId == "D" && CounterofC == true)
                {
                    lstProduct.Add(productC);
                    price = p.ApplyPromotion(lstProduct);
                    discount = 0;

                    totalPrice += price - discount;
                    CounterofC = false;

                }
                else if (p.SKUId == "C" && cart.lstProducts.IndexOf(p) != cart.lstProducts.Count - 1)
                {
                    price = 0;
                    discount = 0;
                }
                else
                {
                    price = p.GetPrice(p);
                    discount = p.ApplyPromotion(lstProduct);
                    totalPrice += price - discount;
                }

                lstProduct.Clear();

                Console.WriteLine(p.Quantity + " * " + p.SKUId + " " + Convert.ToString(price - discount));
            }

            Console.WriteLine("Total " + Convert.ToString(totalPrice));
            Console.WriteLine();

            return totalPrice;
        }
    }
}
