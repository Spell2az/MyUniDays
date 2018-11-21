using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUniDays.Interfaces;

namespace MyUniDays.Discounts
{
    public class NoDiscount : IDiscountPrice
    { 
        public decimal GetDiscountPrice(int quantity, decimal unitPrice) => quantity * unitPrice;

    }
}
