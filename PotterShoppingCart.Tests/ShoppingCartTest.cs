using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PotterShoppingCart;

namespace PotterShoppingCart.Tests
{

    [TestClass()]
    public class ShoppingCartTest
    {
        private List<CarItem> _Items = new List<CarItem>();

        [TestMethod()]
        public void hoppingCartTest_Volume_1_Should_100()
        {
            //Arrange
            var expected = 100;
            var ShoppingCart = new ShoppingCart();
            _Items.Add(new CarItem { Volume = 1, Name = "第一冊", SellPrice = 100, Quantity = 1 });
            //Act
            var actual = ShoppingCart.CalculateShoppingCart(_Items);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
