using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System.Collections.Generic;

namespace ShoppingCartTest
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void TestScenario1()
        {
            //Arrange   
            //Add Products        
            Product p1 = new ProductA() { SKUId = "A", Quantity = 1 };
            Product p2 = new ProductB() { SKUId = "B", Quantity = 1 };
            Product p3 = new ProductC() { SKUId = "C", Quantity = 1 };
            List<Product> lstProducts = new List<Product>();

            lstProducts.Add(p1);
            lstProducts.Add(p2);
            lstProducts.Add(p3);

            //Assign Products to Cart
            ShoppingCart.ShoppingCart cart = new ShoppingCart.ShoppingCart();
            cart.CartId = 100;
            cart.lstProducts = lstProducts;

            //Place Order for Cart
            Order o1 = new Order();
            o1.OrderId = 1;
            o1.OrderDate = DateTime.Now;
            o1.Cart = cart;

            var promotionEngine = new PromotionEngine();

            int expected = 100;

            //Act
            int actual = promotionEngine.Promote(o1.Cart);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestScenario2()
        {
            //Arrange
            //Add Products
            Product p1 = new ProductA() { SKUId = "A", Quantity = 5 };
            Product p2 = new ProductB() { SKUId = "B", Quantity = 5 };
            Product p3 = new ProductC() { SKUId = "C", Quantity = 1 };
            List<Product> lstProducts = new List<Product>();

            lstProducts.Add(p1);
            lstProducts.Add(p2);
            lstProducts.Add(p3);

            //Assign Products to Cart
            ShoppingCart.ShoppingCart cart = new ShoppingCart.ShoppingCart();
            cart.CartId = 101;
            cart.lstProducts = lstProducts;

            //Place Order for Cart
            Order o2 = new Order();
            o2.OrderId = 2;
            o2.OrderDate = DateTime.Now;
            o2.Cart = cart;

            var promotionEngine = new PromotionEngine();

            int expected = 370;

            //Act
            int actual = promotionEngine.Promote(o2.Cart);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestScenario3()
        {
            //Arrange
            //Add Products
            Product p1 = new ProductA() { SKUId = "A", Quantity = 3 };
            Product p2 = new ProductB() { SKUId = "B", Quantity = 5 };
            Product p3 = new ProductC() { SKUId = "C", Quantity = 1 };
            Product p4 = new ProductD() { SKUId = "D", Quantity = 1 };
            List<Product> lstProducts = new List<Product>();

            lstProducts.Add(p1);
            lstProducts.Add(p2);
            lstProducts.Add(p3);
            lstProducts.Add(p4);

            //Assign Products to Cart
            ShoppingCart.ShoppingCart cart = new ShoppingCart.ShoppingCart();
            cart.CartId = 102;
            cart.lstProducts = lstProducts;

            //Place Order for Cart
            Order o3 = new Order();
            o3.OrderId = 3;
            o3.OrderDate = DateTime.Now;
            o3.Cart = cart;

            var promotionEngine = new PromotionEngine();

            int expected = 280;

            //Act
            int actual = promotionEngine.Promote(o3.Cart);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

