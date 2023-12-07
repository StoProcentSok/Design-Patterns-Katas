using Factory_Pattern.Business;
using Factory_Pattern.Business.Models.Commerce;
using Factory_Pattern_First_Look.Business.Models.Shipping.Factories;
using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create Order
            Console.Write("Recipient Country: ");
            var recipientCountry = Console.ReadLine().Trim();

            Console.Write("Sender Country: ");
            var senderCountry = Console.ReadLine().Trim();

            Console.Write("Total Order Weight: ");
            var totalWeight = Convert.ToInt32(Console.ReadLine().Trim());

            var order = new Order
            {
                Recipient = new Address
                {
                    To = "Filip Ekberg",
                    Country = recipientCountry
                },

                Sender = new Address
                {
                    To = "Someone else",
                    Country = senderCountry
                },

                TotalWeight = totalWeight
            };

            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m), 1);
            order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m), 1);
            #endregion

            var shippingProviderFactory = new StandardShippingProviderFactory();
            var cart = new ShoppingCart(order, shippingProviderFactory);

            var shippingLabel = cart.Finalize();

            Console.WriteLine(shippingLabel);
        }
    }
}
