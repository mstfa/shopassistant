using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopAssistant.Factory;
using ShopAssistant.Services;

namespace ShopAssistant.Test
{
    [TestClass]
    public class OfferServiceFactoryTest
    {
        private OfferServiceFactory _factory;
        public OfferServiceFactoryTest()
        {
            _factory = new OfferServiceFactory();
        }
        [TestMethod]
        public virtual void shouldObtainBuy3For2OfferService()
        {
            //given

            //when

            //then
            Assert.IsInstanceOfType(_factory.OfferFor("Orange"), typeof(Buy3For2OfferService));
        }

        [TestMethod]
        public  void shouldObtainBuy1Get1OfferService()
        {
            //given

            //when

            //then
            Assert.IsInstanceOfType(_factory.OfferFor("Apple"), typeof(Buy1Get1OfferService));
        }
    }
}
