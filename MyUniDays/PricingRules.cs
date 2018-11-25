using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUniDays
{
    public class PricingRules
    {
        public List<PricingRule> PricingRulesList { get; } = new List<PricingRule>();

        public void AddPricingRule(PricingRule itemInfo) => PricingRulesList.Add(itemInfo);
        public decimal GetTotalForItemType(char itemCode, int quantity)
        {
            var total = 0.0m;

            if (PricingRuleExists(itemCode))
            {
                var itemInfo = GetItemInfo(itemCode);
                total = itemInfo.ApplyDiscount(quantity);
            }

            return total;
        }

        public PricingRule GetItemInfo(char itemCode)
        {
            return PricingRulesList.Find(item => item.ItemCode == itemCode);
        }

        public bool PricingRuleExists(char itemCode) => PricingRulesList.Exists(item => item.ItemCode == itemCode);
    }
}
