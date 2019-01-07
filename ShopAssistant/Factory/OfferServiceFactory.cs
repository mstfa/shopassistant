using ShopAssistant.Services;
using ShopAssistant.Services.Interface;

namespace ShopAssistant.Factory
{
    public class OfferServiceFactory
    {
        public IOfferService OfferFor(string name)
        {
            switch (name.ToLower())
            {
                case ("apple"):
                    return new Buy1Get1OfferService();
                case ("orange"):
                    return new Buy3For2OfferService();
                default:
                    throw new System.ArgumentException(name + " Item not listed");
            }
        }
    }
}
