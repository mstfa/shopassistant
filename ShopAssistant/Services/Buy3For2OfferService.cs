using ShopAssistant.Services.Interface;

namespace ShopAssistant.Services
{
    public class Buy3For2OfferService : IOfferService
    {
        public int Apply(int[] itemsCost)
        {
            int numberOfItems = itemsCost.Length;

            if (numberOfItems == 0)
            {
                return 0;
            }

            return (numberOfItems / 3) * 2 * itemsCost[0] + (numberOfItems % 3) * itemsCost[0];
        }
    }

}
