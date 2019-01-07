using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopAssistant.Services;

namespace ShopAssistant.Test
{
    [TestClass]
    public class Buy3For2OfferServiceTest
    {
        [TestMethod]
        public void Should_Apply_3For2_Offer()
        {
            //given
            Buy3For2OfferService buy3For2Offer = new Buy3For2OfferService();

            //when

            //then
            Assert.AreEqual(buy3For2Offer.Apply(new int[] { 60 }), 60);
            Assert.AreEqual(buy3For2Offer.Apply(new int[] { 60, 60 }), 120);
            Assert.AreEqual(buy3For2Offer.Apply(new int[] { 60, 60, 60 }), 120);
            Assert.AreEqual(buy3For2Offer.Apply(new int[] { 60, 60, 60, 60 }), 180);
        }
    }
}
