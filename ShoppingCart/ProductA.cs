using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ProductA : Product
    {

        public ProductA()
        {
            this.Price = 50;
        }

        /// <summary>
        /// Promotion Logic for Product A
        /// </summary>
        /// <param name="lstProducts"></param>
        /// <returns></returns>
        /// 
        public override int ApplyPromotion(List<Product> lstProducts)
        {
            Product prod = lstProducts[0];

            int nonDiscountedQty = prod.Quantity % 3;
            int discountedQty = prod.Quantity - nonDiscountedQty;
            int discountMultiple = discountedQty / 3;
            int discountAmount = 20;
            int discountPrice = 0;

            discountPrice = discountMultiple * discountAmount;
            return discountPrice;
        }
    }
}
