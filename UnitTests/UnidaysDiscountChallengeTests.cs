using System;
using MyUniDays;
using MyUniDays.Discounts;
using NUnit.Framework;

namespace UnidaysDiscountChallengeUnitTests
{
    [TestFixture]
    public class UnidaysDiscountChallengeTests
    {
        static PricingRules PricingRulesSetup()
        {
            var pricingRules = new PricingRules();

            var pricingRuleItemA = new ItemInfo(8.0m, 'A', new NoDiscount());
            var pricingRuleItemB = new ItemInfo(12.0m, 'B', new GetMItemsForNPrice(2, 20m));
            var pricingRuleItemC = new ItemInfo(4.0m, 'C', new GetMItemsForNPrice(3, 10m));
            var pricingRuleItemD = new ItemInfo(7.0m, 'D', new GetMForNItems(2, 1));
            var pricingRuleItemE = new ItemInfo(5.0m, 'E', new GetMForNItems(3, 2));

            pricingRules.AddPricingRule(pricingRuleItemA);
            pricingRules.AddPricingRule(pricingRuleItemB);
            pricingRules.AddPricingRule(pricingRuleItemC);
            pricingRules.AddPricingRule(pricingRuleItemD);
            pricingRules.AddPricingRule(pricingRuleItemE);

            return pricingRules;
        }
        [Test]
        public void ItemPrice_A()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasket('A');
            

            Assert.That(discounts.Total, Is.EqualTo(8.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_B()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasket('B');


            Assert.That(discounts.Total, Is.EqualTo(12.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_C()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasket('C');


            Assert.That(discounts.Total, Is.EqualTo(4.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_D()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasket('D');


            Assert.That(discounts.Total, Is.EqualTo(7.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_E()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasket('E');


            Assert.That(discounts.Total, Is.EqualTo(5.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }
        [Test]
        public void ItemPrice_BB()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("BB");


            Assert.That(discounts.Total, Is.EqualTo(20.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_BBB()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("BBB");


            Assert.That(discounts.Total, Is.EqualTo(32.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_BBBB()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("BBBB");


            Assert.That(discounts.Total, Is.EqualTo(40.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_CCC()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("CCC");


            Assert.That(discounts.Total, Is.EqualTo(10.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_CCCC()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("CCCC");


            Assert.That(discounts.Total, Is.EqualTo(14.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_DD()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("DD");


            Assert.That(discounts.Total, Is.EqualTo(7.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_DDD()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("DDD");


            Assert.That(discounts.Total, Is.EqualTo(14.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_EE()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("EE");


            Assert.That(discounts.Total, Is.EqualTo(10.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_EEE()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("EEE");


            Assert.That(discounts.Total, Is.EqualTo(10.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_EEEE()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("EEEE");


            Assert.That(discounts.Total, Is.EqualTo(15.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_DDDDDDDDDDDDDD()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("DDDDDDDDDDDDDD");


            Assert.That(discounts.Total, Is.EqualTo(49.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void ItemPrice_BBBBCCC()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("BBBBCCC");


            Assert.That(discounts.Total, Is.EqualTo(50.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(0.0m));
        }

        [Test]
        public void ItemPrice_ABBCCCDDEE()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("ABBCCCDDEE");


            Assert.That(discounts.Total, Is.EqualTo(55.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(0.0m));
        }

        [Test]
        public void ItemPrice_EDCBAEDCBC()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("EDCBAEDCBC");


            Assert.That(discounts.Total, Is.EqualTo(55.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(0.0m));
        }
    }
}
