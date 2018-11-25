using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyUniDays;
using MyUniDays.Discounts;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UnitTests
{
    [TestFixture]
    public class UnidaysDiscountChallengeTests
    {
        static PricingRules PricingRulesSetup()
        {
            var pricingRules = new PricingRules();

            var pricingRuleA = new PricingRule(8.0m, 'A', new NoDiscount());
            var pricingRuleB = new PricingRule(12.0m, 'B', new GetMItemsForNPrice(2, 20m));
            var pricingRuleC = new PricingRule(4.0m, 'C', new GetMItemsForNPrice(3, 10m));
            var pricingRuleD = new PricingRule(7.0m, 'D', new GetMItemsPayForNItems(2, 1));
            var pricingRuleE = new PricingRule(5.0m, 'E', new GetMItemsPayForNItems(3, 2));

            pricingRules.AddPricingRule(pricingRuleA);
            pricingRules.AddPricingRule(pricingRuleB);
            pricingRules.AddPricingRule(pricingRuleC);
            pricingRules.AddPricingRule(pricingRuleD);
            pricingRules.AddPricingRule(pricingRuleE);

            return pricingRules;
        }

        [Test]
        
        public void TestAddingItemToBasketNotInThePricingRules_ThrowsException_itemR()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());
            Assert.That(() => discounts.AddToBasket('R'), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void TestTotalAndDeliveryChargeFor_item_A()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasket('A');
            

            Assert.That(discounts.Total, Is.EqualTo(8.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeFor_item_B()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasket('B');


            Assert.That(discounts.Total, Is.EqualTo(12.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_C()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasket('C');


            Assert.That(discounts.Total, Is.EqualTo(4.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_D()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasket('D');


            Assert.That(discounts.Total, Is.EqualTo(7.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_E()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasket('E');


            Assert.That(discounts.Total, Is.EqualTo(5.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_BB()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());
            
            discounts.AddToBasketBulk("BB");


            Assert.That(discounts.Total, Is.EqualTo(20.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_BBB()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("BBB");


            Assert.That(discounts.Total, Is.EqualTo(32.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_BBBB()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("BBBB");


            Assert.That(discounts.Total, Is.EqualTo(40.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_CCC()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("CCC");


            Assert.That(discounts.Total, Is.EqualTo(10.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_CCCC()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("CCCC");


            Assert.That(discounts.Total, Is.EqualTo(14.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_DD()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("DD");


            Assert.That(discounts.Total, Is.EqualTo(7.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_DDD()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("DDD");


            Assert.That(discounts.Total, Is.EqualTo(14.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_EE()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("EE");


            Assert.That(discounts.Total, Is.EqualTo(10.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_EEE()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("EEE");


            Assert.That(discounts.Total, Is.EqualTo(10.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_EEEE()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("EEEE");


            Assert.That(discounts.Total, Is.EqualTo(15.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_DDDDDDDDDDDDDD()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("DDDDDDDDDDDDDD");


            Assert.That(discounts.Total, Is.EqualTo(49.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(7.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_BBBBCCC()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("BBBBCCC");


            Assert.That(discounts.Total, Is.EqualTo(50.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(0.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_ABBCCCDDEE()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("ABBCCCDDEE");


            Assert.That(discounts.Total, Is.EqualTo(55.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(0.0m));
        }

        [Test]
        public void TestTotalAndDeliveryChargeForItem_EDCBAEDCBC()
        {
            var discounts = new UnidaysDiscountChallenge(PricingRulesSetup());

            discounts.AddToBasketBulk("EDCBAEDCBC");


            Assert.That(discounts.Total, Is.EqualTo(55.0m));
            Assert.That(discounts.DeliveryCharge, Is.EqualTo(0.0m));
        }

    }
}
