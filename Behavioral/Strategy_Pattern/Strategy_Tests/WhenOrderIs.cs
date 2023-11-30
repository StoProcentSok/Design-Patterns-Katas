using NUnit.Framework;
using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Tests
{
    [TestFixture]
    public class WhenOrderIs
    {
        
        

        [Test]
        public void FromSwedenToSweden_AndPrice100_ThenTaxShouldBe_25()
        {
            var order = GetOrder("Sweden", "Sweden", 100m);

            var swedishTax = order.GetTax();
            Assert.AreEqual(swedishTax, 25m);
        }

        [Test]
        public void FromSwedenToUSLA_AndPrice100_ThenTaxShouldBe9_5 ()
        {
            var order = GetOrder("us", "us", 100m, "la");
            var usLaTax = order.GetTax();

            Assert.AreEqual(usLaTax, 9.5m);
        }

        [Test]
        public void FromSwedenToUSNY_AndPrice100_ThenTaxShouldBe4()
        {
            var order = GetOrder("us", "us", 100m, "ny");
            var usLaTax = order.GetTax();

            Assert.AreEqual(usLaTax, 4m);
        }

        [Test]
        public void FromSwedenToUSNYC_AndPrice100_ThenTaxShouldBe4_5()
        {
            var order = GetOrder("us", "us", 100m, "nyc");
            var usLaTax = order.GetTax();

            Assert.AreEqual(usLaTax, 4.5m);
        }

        private Order GetOrder(string originCountry, string destCountry, decimal price, string destState = "")
        {
            var order = new Order(originCountry, destCountry, destState);

            order.LineItems.Add(new Item("1", "Item 1", price, ItemType.Hardware), 1);

            return order;
        }
    }
}
