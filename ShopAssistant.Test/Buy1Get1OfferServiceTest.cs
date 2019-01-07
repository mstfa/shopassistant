using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopAssistant.Services;

namespace ShopAssistant.Test
{
    [TestClass]
    public class Buy1Get1OfferServiceTest
    {
        [TestMethod]
        public  void Should_Apply_Buy1Get1_Offer()
        {
            //given
            Buy1Get1OfferService buy1Get1Offer = new Buy1Get1OfferService();

            //when

            //then
            Assert.AreEqual( buy1Get1Offer.Apply(new int[] { 60 }), 60);
            Assert.AreEqual( buy1Get1Offer.Apply(new int[] { 60, 60 }), 60);
            Assert.AreEqual( buy1Get1Offer.Apply(new int[] { 60, 60, 60 }), 120);
        }

    }
}
