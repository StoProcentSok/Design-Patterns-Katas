
using Factory_Pattern_First_Look.Business;
using Factory_Pattern_First_Look.Business.Models.Commerce;
using NUnit.Framework;

namespace FactoryAbstractFactory_Tests
{
    [TestFixture]
    public class WhenOrderIs
    {

        public void ThenProperLableIsGenerated()
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

            
        }
    }
}
