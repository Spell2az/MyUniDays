using System;
using MyUniDays.Interfaces;

namespace MyUniDays.Discounts
{

    public class GetMForNItems:  IDiscountPrice
        {
            private int m;
            private int n;

            public GetMForNItems(int m, int n)
            {
                this.m = m;
                this.n = n;
            }


            public decimal GetDiscountPrice(decimal price, int quantity)
            {
                return price * ((decimal) (Math.Floor((decimal)quantity / m) * n) + quantity % m);
            }
        }
    }

