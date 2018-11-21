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
        public decimal Price { get; set; }
        public char ItemCode { get; set; }
       

        public ItemInfo(decimal price, char itemCode)
        {
            Price = price;
            ItemCode = itemCode;
        }

        public decimal ApplyDiscount(int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
