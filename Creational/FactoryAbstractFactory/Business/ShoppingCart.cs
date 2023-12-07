using Factory_Pattern.Business.Models.Commerce;
using Factory_Pattern.Business.Models.Shipping;
using Factory_Pattern_First_Look.Business.Models.Shipping.Factories;
using System;

namespace Factory_Pattern.Business
{
    public class ShoppingCart
    {
        private readonly Order order;
        private readonly ShippingProviderFactory shippingProviderFactory;

        public ShoppingCart(Order order, ShippingProviderFactory shippingProviderFactory)
        {
            this.order = order;
            this.shippingProviderFactory = shippingProviderFactory;
        }

        public string Finalize()    
        {
            
            var shippingProvider = this.shippingProviderFactory.CreateShippingProvider(this.order.Sender.Country);

            order.ShippingStatus = ShippingStatus.ReadyForShippment;

            return shippingProvider.GenerateShippingLabelFor(order);
        }
    }
}
