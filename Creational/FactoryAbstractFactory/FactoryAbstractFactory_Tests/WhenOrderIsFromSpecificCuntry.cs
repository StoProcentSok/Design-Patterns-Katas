using FluentAssertions;
using Factory_Pattern.Business;
using Factory_Pattern.Business.Models.Commerce;
using NUnit.Framework;
using Factory_Pattern_First_Look.Business.Models.Shipping.Factories;

namespace FactoryAbstractFactory_Tests
{
    [TestFixture]
    public class WhenOrderIsFromSpecificCuntry
    {
        [Test]
        public void ThenProperLableIsGeneratedForSwedishOrder()
        {
            var orderFactory = new SwedishOrderFactory();
            var order = orderFactory.GetOrder();

            var shippingProviderFactory = new StandardShippingProviderFactory();
            var cart = new ShoppingCart(order, shippingProviderFactory);

            var shippingLabel = cart.Finalize();

            var expected = "Shipping Id: 404 \r\nTo: Filip Ekberg \r\nOrder total: 200 \r\nTax: PayOnArrival \r\nShipping Cost: 130";

            shippingLabel.Should().BeEquivalentTo(expected);
        }

        [Test]
        
        public void ThenProperLableIsGeneratedForAustralianOrder()
        {
            var orderFactory = new AustralianOrderFactory();
            var order = orderFactory.GetOrder();

            var shippingProviderFactory = new StandardShippingProviderFactory();
            var cart = new ShoppingCart(order, shippingProviderFactory);

            var shippingLabel = cart.Finalize();

            var expected = "Shipping Id: 404 \r\nTo: Filip Ekberg \r\nOrder total: 200 \r\nTax: PayOnArrival \r\nShipping Cost: 130";

            shippingLabel.Should().BeEquivalentTo(expected);
        }
    }
}
