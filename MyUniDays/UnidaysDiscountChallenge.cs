using System.Collections.Generic;

namespace MyUniDays
{
    public class UnidaysDiscountChallenge
    {
        public decimal Total => CalculateTotal();
        public decimal DeliveryCharge => Total > 50.0m ? 0.0m : 7.0m;
        public Dictionary<char, int> Basket  = new Dictionary<char, int>();
        private PricingRules pricingRules;

        public UnidaysDiscountChallenge(PricingRules pricingRules)
        {
            this.pricingRules = pricingRules;
        }
        public void AddToBasket(char item)
        {
            if (Basket.ContainsKey(item))
            {
                Basket[item]++;
            }
            else
            {
                Basket.Add(item, 1);
            }
        }

        public decimal CalculateTotal()
        {
            decimal totalPrice = 0;

            foreach (var item in Basket)
            {
                totalPrice += pricingRules.GetTotalForItemType(item.Key, item.Value);
            }

            return totalPrice;
        }
    }
}