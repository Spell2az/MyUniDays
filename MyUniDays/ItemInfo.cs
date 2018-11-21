using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUniDays.Interfaces;

namespace MyUniDays
{
    public class ItemInfo
    {
        private IDiscountPrice discount;
        public decimal Price { get; set; }
        public char ItemCode { get; set; }
       

        public ItemInfo(decimal price, char itemCode, IDiscountPrice discount)
        {
            Price = price;
            ItemCode = itemCode;
            this.discount = discount;
        }

        public decimal ApplyDiscount(int quantity)
        {
            return discount.GetDiscountPrice(Price, quantity);
        }
    }
}
