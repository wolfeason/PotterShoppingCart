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
        public void ShoppingCartTest_Volume_1_Should_100()
        {
            //第一集買了一本，其他都沒買，價格應為100*1=100元
            //Arrange
            var expected = 100;
            var shoppingcart = new ShoppingCart();
            _Items.Add(new CarItem { Volume = 1, Name = "第一冊", SellPrice = 100, Quantity = 1 });
            //Act
            var actual = shoppingcart.CalculateShoppingCart(_Items);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ShoppingCartTest_Volume_1_Volume_2_Should_190()
        {
            //第一集買了一本，第二集也買了一本，價格應為100*2*0.95=190
            var expected = 190;
            var shoppingcart = new ShoppingCart();
            _Items.Add(new CarItem { Volume = 1, Name = "第一冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 2, Name = "第二冊", SellPrice = 100, Quantity = 1 });
            //Act
            var actual = shoppingcart.CalculateShoppingCart(_Items);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod()]
        public void ShoppingCartTest_Volume_1_Volume_2_Volume_3_Should_270()
        {
            //一二三集各買了一本，價格應為100*3*0.9=270
            var expected = 270;
            var shoppingcart = new ShoppingCart();
            _Items.Add(new CarItem { Volume = 1, Name = "第一冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 2, Name = "第二冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 3, Name = "第三冊", SellPrice = 100, Quantity = 1 });
            //Act
            var actual = shoppingcart.CalculateShoppingCart(_Items);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ShoppingCartTest_Volume_1_Volume_2_Volume_3_Volume_4_Should_320()
        {
            //一二三四集各買了一本，價格應為100*4*0.8=320
            var expected = 320;
            var shoppingcart = new ShoppingCart();
            _Items.Add(new CarItem { Volume = 1, Name = "第一冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 2, Name = "第二冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 3, Name = "第三冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 4, Name = "第四冊", SellPrice = 100, Quantity = 1 });
            //Act
            var actual = shoppingcart.CalculateShoppingCart(_Items);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
