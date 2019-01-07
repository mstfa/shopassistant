using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopAssistant.Factory;

namespace ShopAssistant.Test
{
    [TestClass]
    public class CheckoutSystemIntegrationTest
    {
        private CheckoutSystem _checkoutSystem;
        public CheckoutSystemIntegrationTest()
        {
            _checkoutSystem = new CheckoutSystem(new OfferServiceFactory());
        }

        [TestMethod]
        public  void Should_PrintReceipt_For_ShoppingCartContainingApples_After_BuyOneGetOneOffer()
        {
            //given

            //when

            //then
            Assert.AreEqual( _checkoutSystem.PrintReceipt(new List<string> { "Apple" }), "£0.60");
            Assert.AreEqual( _checkoutSystem.PrintReceipt(new List<string> { "Apple", "Apple" }), "£0.60");
            Assert.AreEqual( _checkoutSystem.PrintReceipt(new List<string> { "Apple", "Apple", "Apple" }), "£1.20");
        }

        [TestMethod]
        public void Should_PrintReceipt_For_ShoppingCartContainingOranges_After3For2Offer()
        {
            //given

            //when

            //then
            Assert.AreEqual( _checkoutSystem.PrintReceipt(new List<string> { "Orange" }), "£0.25");
            Assert.AreEqual( _checkoutSystem.PrintReceipt(new List<string> { "Orange", "Orange" }), "£0.50");
            Assert.AreEqual( _checkoutSystem.PrintReceipt(new List<string> { "Orange", "Orange", "Orange" }), "£0.50");
            Assert.AreEqual( _checkoutSystem.PrintReceipt(new List<string> { "Orange", "Orange", "Orange", "Orange" }), "£0.75");
        }

        [TestMethod]
        public  void Should_PrintReceipt_ForShoppingCartContainingApplesAndOranges_AfterOffers()
        {
            //given

            //when

            //then
            Assert.AreEqual(_checkoutSystem.PrintReceipt(new List<string> { "Apple", "Apple", "Orange" }), "£0.85");
            Assert.AreEqual(_checkoutSystem.PrintReceipt(new List<string> { "Apple", "Apple", "Orange", "Orange", "Orange" }), "£1.10");
        }
    }
}
