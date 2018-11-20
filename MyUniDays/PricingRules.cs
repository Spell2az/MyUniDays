using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUniDays
{
    public class PricingRules
    {
        public List<ItemInfo> ItemInfoList { get; } = new List<ItemInfo>();

        public void AddPricingRule(ItemInfo itemInfo) => ItemInfoList.Add(itemInfo);
        public decimal GetTotalForItemType(char itemCode, int quantity)
        {
            var total = 0.0m;

            if (ItemInfoList.Exists(item => item.ItemCode == itemCode))
            {
                var itemInfo = GetItemInfo(itemCode);
                total = itemInfo.ApplyDiscount(quantity);
            }

            return total;
        }

        public ItemInfo GetItemInfo(char itemCode)
        {
            return ItemInfoList.Find(item => item.ItemCode == itemCode);
        }
    }
}
