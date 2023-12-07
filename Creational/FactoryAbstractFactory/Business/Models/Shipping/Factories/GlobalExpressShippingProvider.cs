using Factory_Pattern.Business.Models.Commerce;
using Factory_Pattern.Business.Models.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_First_Look.Business.Models.Shipping.Factories
{
    internal class GlobalExpressShippingProvider : ShippingProvider
    {
        public override string GenerateShippingLabelFor(Order order)
        {
            return "Label";
        }
    }
}
