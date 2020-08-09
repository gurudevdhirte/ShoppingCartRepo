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
        public void CheckPromotionForProductA()
        {
            //Arrange
            var objProductA = new ProductA() { SKUId = "A", Quantity = 5 };
            List<Product> lstProducts = new List<Product>();
            lstProducts.Add(objProductA);
            int expected = 20;

            //Act
            int actual = objProductA.ApplyPromotion(lstProducts);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckPromotionForProductB()
        {
            //Arrange
            var objProductB = new ProductB() { SKUId = "B", Quantity = 2 };
            List<Product> lstProducts = new List<Product>();
            lstProducts.Add(objProductB);
            int expected = 15;

            //Act
            int actual = objProductB.ApplyPromotion(lstProducts);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckPromotionForProductCAndD()
        {
            //Arrange
            var objProductC = new ProductC() { SKUId = "C", Quantity = 1 };
            var objProductD = new ProductD() { SKUId = "D", Quantity = 1 };
            List<Product> lstProducts = new List<Product>();
            lstProducts.Add(objProductD);
            lstProducts.Add(objProductC);
            int expected = 30;

            //Act
            int actual = objProductD.ApplyPromotion(lstProducts);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}

