using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUniDays
{
    class Discount
    {
        public Discount(Enum discountType, int BuyQuantity, int BuyItForHowManu, decimal BuyForHowMuch)
        {
            this.DiscountType = discountType;
        }

        public int GetDiscount()
        {
            return 0;
        }
        public Discount()
        {
            
        }

        private int BuyNforM(int n, int m)
        {
            return 0;
        }
        public Enum DiscountType { get; }
    }
}
