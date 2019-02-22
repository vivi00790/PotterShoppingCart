﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void GetTotalPrize_Buy_Nothing_Should_return_0()
        {
            var books = new List<Book>();
            TotalPrizeShouldBe(0, books);
        }

        [TestMethod]
        public void GetTotalPrize_Buy_One_EP1_Should_return_100()
        {
            var books = new List<Book> { new Book() { ISBN = "1" } };
            TotalPrizeShouldBe(100, books);
        }

        [TestMethod]
        public void GetTotalPrize_Buy_Two_Different_Episode_Should_return_190()
        {
            var books = new List<Book> { new Book() { ISBN = "1" }, new Book() { ISBN = "2" } };
            TotalPrizeShouldBe(190, books);
        }

        private static void TotalPrizeShouldBe(int expected, List<Book> books)
        {
            var cart = new Cart();
            var actual = cart.GetTotalPrize(books);
            Assert.AreEqual(expected, actual);
        }
    }
}
