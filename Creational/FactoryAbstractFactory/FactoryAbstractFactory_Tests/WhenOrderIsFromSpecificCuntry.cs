using FluentAssertions;
using Factory_Pattern.Business;
using Factory_Pattern.Business.Models.Commerce;
using NUnit.Framework;

namespace FactoryAbstractFactory_Tests
{
    [TestFixture]
    public class WhenOrderIsFromSpecificCuntry
    {
        [Test]
        public void ThenProperLableIsGeneratedForSwedishOrder()
        {
            var order = new Order
            {
                Recipient = new Address
                {
                    To = "Filip Ekberg",
                    Country = "Sweden"
                },

                Sender = new Address
                {
                    To = "Someone else",
                    Country = "Sweden"
                },

                TotalWeight = 30,
            };

            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m), 1);
            order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m), 1);


            var cart = new ShoppingCart(order);

            var shippingLabel = cart.Finalize();

            var expected = "Shipping Id: 404 \r\nTo: Filip Ekberg \r\nOrder total: 200 \r\nTax: PayOnArrival \r\nShipping Cost: 130";

            shippingLabel.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void ThenProperLableIsGeneratedForAustralianOrder()
        {
            var order = new Order
            {
                Recipient = new Address
                {
                    To = "Filip Ekberg",
                    Country = "Sweden"
                },

                Sender = new Address
                {
                    To = "Someone else",
                    Country = "Australia"
                },

                TotalWeight = 30,
            };

            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m), 1);
            order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m), 1);


            var cart = new ShoppingCart(order);

            var shippingLabel = cart.Finalize();

            var expected = "Shipping Id: 404 \r\nTo: Filip Ekberg \r\nOrder total: 200 \r\nTax: PayOnArrival \r\nShipping Cost: 130";

            shippingLabel.Should().BeEquivalentTo(expected);
        }
    }
}
