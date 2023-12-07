using Factory_Pattern.Business.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstractFactory_Tests
{
    public abstract class OrderFactory
    {
        public abstract Order CreateOrder();

        public Order GetOrder()
        {
            var order = CreateOrder();

            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m), 1);
            order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m), 1);

            return order;
        }
    }

    public class SwedishOrderFactory() : OrderFactory
    {
        public override Order CreateOrder()
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

            return order;
        }
    }

    public class AustralianOrderFactory() : OrderFactory
    {
        public override Order CreateOrder()
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

            return order;
        }
    }
}
