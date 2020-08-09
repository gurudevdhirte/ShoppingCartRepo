using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ProductD : Product
    {
        public ProductD()
        {
            this.Price = 15;
        }

        //Promotion Logic for Product C and D
        public override int ApplyPromotion(List<Product> lstProducts)
        {
            if (lstProducts.Count == 2)
            {
                Product p1 = lstProducts[1];
                Product p2 = lstProducts[0];

                int discountAmount = 5;

                int finalDiscountedPrice = 0;

                finalDiscountedPrice = (p1.Price + p2.Price) - discountAmount;

                return finalDiscountedPrice;
            }
            else
            {
                return 0;
            }
        }

        
    }
}
