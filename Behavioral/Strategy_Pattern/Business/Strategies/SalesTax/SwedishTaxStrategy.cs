using Strategy_Pattern_First_Look.Business.Models;
using System.Linq;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    internal class SwedishTaxStrategy : IOrderTaxStrategy
    {
        public decimal GetTax(Order order)
        {
            var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();
            var totalPrice = order.LineItems.Sum(item => item.Key.Price * item.Value);

            if (destination == order.ShippingDetails.OriginCountry.ToLowerInvariant())
            {
                decimal totalTax = 0m;
                foreach (var item in order.LineItems)
                {
                    switch (item.Key.ItemType)
                    {
                        case ItemType.Food:
                            totalTax += item.Key.Price * 0.06m * item.Value;
                            break;

                        case ItemType.Literature:
                            totalTax += item.Key.Price * 0.08m * item.Value;
                            break;

                        case ItemType.Service:
                        case ItemType.Hardware:
                            totalTax += item.Key.Price * 0.25m * item.Value;
                            break;
                    }
                }
                return totalTax;
            }
            return 0;
        }
    }
}
