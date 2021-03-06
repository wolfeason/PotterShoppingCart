﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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


        [TestMethod()]
        public void ShoppingCartTest_Volume_1_Volume_2_Volume_3_Volume_4_Volume_5_Should_375()
        {
            //一次買了整套，一二三四五集各買了一本，價格應為100*5*0.75=375
            var expected = 375;
            var shoppingcart = new ShoppingCart();
            _Items.Add(new CarItem { Volume = 1, Name = "第一冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 2, Name = "第二冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 3, Name = "第三冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 4, Name = "第四冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 5, Name = "第五冊", SellPrice = 100, Quantity = 1 });
            //Act
            var actual = shoppingcart.CalculateShoppingCart(_Items);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ShoppingCartTest_Volume_1_Volume_2_Volume_3_Volume_3_Should_370()
        {
            //一二集各買了一本，第三集買了兩本，價格應為100*3*0.9 + 100 = 370
            var expected = 370;
            var shoppingcart = new ShoppingCart();
            _Items.Add(new CarItem { Volume = 1, Name = "第一冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 2, Name = "第二冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 3, Name = "第三冊", SellPrice = 100, Quantity = 2 });
            //Act
            var actual = shoppingcart.CalculateShoppingCart(_Items);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ShoppingCartTest_Volume_1_Volume_2_Volume_2_Volume_3_Volume_3_Should_460()
        {
            //第一集買了一本，第二三集各買了兩本，價格應為100*3*0.9 + 100*2*0.95 = 460
            var expected = 460;
            var shoppingcart = new ShoppingCart();
            _Items.Add(new CarItem { Volume = 1, Name = "第一冊", SellPrice = 100, Quantity = 1 });
            _Items.Add(new CarItem { Volume = 2, Name = "第二冊", SellPrice = 100, Quantity = 2 });
            _Items.Add(new CarItem { Volume = 3, Name = "第三冊", SellPrice = 100, Quantity = 2 });
            //Act
            var actual = shoppingcart.CalculateShoppingCart(_Items);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ShoppingCartTest_Volume_1_Buy_99_Should_460()
        {
            //第一集買了九十九本，其他都沒買，價格應為100*99 =9900
            var expected = 9900;
            var shoppingcart = new ShoppingCart();
            _Items.Add(new CarItem { Volume = 1, Name = "第一冊", SellPrice = 100, Quantity = 99 });
            //Act
            var actual = shoppingcart.CalculateShoppingCart(_Items);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ShoppingCartTest_Volume_1_Buy_2_Volume_2_Buy_4_Volume_3_Buy_6_Should_1120()
       { 
            //(綠燈)第一集買了兩本，第二集買了四本，第三集買了六本，價格應為100*3*0.9*2 + 100*2*0.95*2 + 100*1*2 =1120
            var expected = 1120;
            var shoppingcart = new ShoppingCart();
            _Items.Add(new CarItem { Volume = 1, Name = "第一冊", SellPrice = 100, Quantity = 2 });
            _Items.Add(new CarItem { Volume = 2, Name = "第二冊", SellPrice = 100, Quantity = 4 });
            _Items.Add(new CarItem { Volume = 3, Name = "第三冊", SellPrice = 100, Quantity = 6 });
            //Act
            var actual = shoppingcart.CalculateShoppingCart(_Items);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
