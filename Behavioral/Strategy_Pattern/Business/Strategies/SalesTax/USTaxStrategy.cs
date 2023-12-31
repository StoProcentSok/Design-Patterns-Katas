﻿using Strategy_Pattern.Business.Models;

namespace Strategy_Pattern.Business.Strategies.SalesTax
{
    internal class USTaxStrategy : IOrderTaxStrategy
    {
        public decimal GetTax(Order order)
        {
            switch (order.ShippingDetails.DestinationState.ToLowerInvariant())
            {
                case "la": return order.TotalPrice * 0.095m;
                case "ny": return order.TotalPrice * 0.04m;
                case "nyc": return order.TotalPrice * 0.045m;
                default: return 0m;
            }
        }
    }
}
