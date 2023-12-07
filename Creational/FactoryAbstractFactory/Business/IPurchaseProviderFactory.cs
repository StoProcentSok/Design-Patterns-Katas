using Factory_Pattern.Business.Models.Commerce;
using Factory_Pattern.Business.Models.Shipping;
using Factory_Pattern_First_Look.Business.Models.Commerce.Invoice;
using Factory_Pattern_First_Look.Business.Models.Commerce.Summary;
using Factory_Pattern_First_Look.Business.Models.Shipping.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_First_Look.Business
{
    public interface IPurchaseProviderFactory
    {
        ShippingProvider CreateShippingProvider(Order order);
        IInvoice CreateInvoice(Order order);
        ISummary CreateSummary(Order order);
    }

    public class AustralianPurchaseProviderFactory : IPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            return new GSTInvoice();
        }

        public ShippingProvider CreateShippingProvider(Order order)
        {
            var shippingProviderFactory = new StandardShippingProviderFactory();
            return shippingProviderFactory.GetShippingProvider(order.Sender.Country);
        }

        public ISummary CreateSummary(Order order)
        {
            return new CsVSummary();
        }
    }

    public class SwedenPurchaseProviderFactory : IPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            if (order.Recipient.Country != order.Sender.Country)
            {
                return new NoVatInvoice();
            }
            else
            {
                return new VATInvoice();
            }
        }

        public ShippingProvider CreateShippingProvider(Order order)
        {
            ShippingProviderFactory shippingProviderFactory;
            if (order.Recipient.Country != order.Sender.Country)
            {
                shippingProviderFactory = new GlobalExpressShippingFactory();
            }
            else
            {
                shippingProviderFactory = new StandardShippingProviderFactory();
            }
            return shippingProviderFactory.GetShippingProvider(order.Sender.Country);
        }

        public ISummary CreateSummary(Order order)
        {
            return new EmailSummary();
        }
    }
}
