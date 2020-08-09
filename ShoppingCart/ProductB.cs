using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ProductB : Product
    {
        public ProductB()
        {
            this.Price = 30;
        }

        /// <summary>
        /// Promotion Logic for Product B
        /// </summary>
        /// <param name="lstProducts"></param>
        /// <returns></returns>
        public override int ApplyPromotion(List<Product> lstProducts)
        {
            Product prod = lstProducts[0];

            int nonDiscountedQty = prod.Quantity % 2;
            int discountedQty = prod.Quantity - nonDiscountedQty;
            int discountMultiple = discountedQty / 2;
            int discountAmount = 15;
            int discountPrice = 0;

            discountPrice = discountMultiple * discountAmount;
            return discountPrice;
        }        
    }
}
