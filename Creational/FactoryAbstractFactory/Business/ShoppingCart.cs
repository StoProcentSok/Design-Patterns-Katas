using Factory_Pattern.Business.Models.Commerce;
using Factory_Pattern.Business.Models.Shipping;
using Factory_Pattern_First_Look.Business;
using Factory_Pattern_First_Look.Business.Models.Shipping.Factories;
using System;

namespace Factory_Pattern.Business
{
    public class ShoppingCart
    {
        private readonly Order order;
        private readonly IPurchaseProviderFactory purchaseProviderFactory;

        public ShoppingCart(Order order, IPurchaseProviderFactory purchaseProviderFactory)
        {
            this.order = order;
            this.purchaseProviderFactory = purchaseProviderFactory;
        }

        public string Finalize()    
        {
            
            var shippingProvider = this.purchaseProviderFactory.CreateShippingProvider(this.order);

            var invoice = this.purchaseProviderFactory.CreateInvoice(this.order);

            order.ShippingStatus = ShippingStatus.ReadyForShippment;

            return shippingProvider.GenerateShippingLabelFor(order);
        }
    }
}
