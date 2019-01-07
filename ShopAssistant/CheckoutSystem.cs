using ShopAssistant.Factory;
using System.Collections.Generic;
using System.Linq;

namespace ShopAssistant
{
    public class CheckoutSystem
    {
        private const int APPLE_COST = 60;
        private const int ORANGE_COST = 25;
        private const string APPLE = "Apple";
        private const string ORANGE = "Orange";

        private OfferServiceFactory _offerServiceFactory = new OfferServiceFactory();

        public CheckoutSystem(OfferServiceFactory offerServiceFactory)
        {
            offerServiceFactory = _offerServiceFactory;
        }

        public virtual string PrintReceipt(IList<string> shoppingCart)
        {

            decimal total = new decimal(Scan(shoppingCart) * .01);

            return string.Format("{0:C}", total);
        }


        private int Scan(IList<string> shoppingCart)
        {
            int total = 0;

            int apples = Search(shoppingCart.ToArray(), APPLE);
            int[] temArrApple = new int[apples];
            for (int i = 0; i < temArrApple.Length; i++)
            {
                temArrApple[i] = APPLE_COST;
            }

            total += _offerServiceFactory.OfferFor(APPLE).Apply(temArrApple);

            int oranges = Search(shoppingCart.ToArray(), ORANGE);

            int[] temArrOrange = new int[oranges];
            for (int i = 0; i < temArrOrange.Length; i++)
            {
                temArrOrange[i] = ORANGE_COST;
            }
            total += _offerServiceFactory.OfferFor(ORANGE).Apply(temArrOrange);

            return total;
        }

        private int Search(string[] arr, string s)
        {
            int counter = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (s.Equals(arr[j]))
                    counter++;
            }
            return counter;
        }
    }
}
