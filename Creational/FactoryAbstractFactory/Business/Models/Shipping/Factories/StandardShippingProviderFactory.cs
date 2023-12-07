using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Pattern.Business.Models.Shipping;

namespace Factory_Pattern_First_Look.Business.Models.Shipping.Factories
{
    public abstract class ShippingProviderFactory
    {
        public abstract ShippingProvider CreateShippingProvider(string senderCountry);

        public ShippingProvider GetShippingProvider(string country)
        {
            var provider = CreateShippingProvider(country);
            return provider;
        }
    }

    public class StandardShippingProviderFactory : ShippingProviderFactory
    {
        public override ShippingProvider CreateShippingProvider(string senderCountry)
        {
            #region Create Shipping Provider
            ShippingProvider shippingProvider;

            if (senderCountry == "Australia")
            {
                #region Australia Post Shipping Provider
                var shippingCostCalculator = new ShippingCostCalculator(
                    internationalShippingFee: 250,
                    extraWeightFee: 500
                )
                {
                    ShippingType = ShippingType.Standard
                };

                var customsHandlingOptions = new CustomsHandlingOptions
                {
                    TaxOptions = TaxOptions.PrePaid
                };

                var insuranceOptions = new InsuranceOptions
                {
                    ProviderHasInsurance = false,
                    ProviderHasExtendedInsurance = false,
                    ProviderRequiresReturnOnDamange = false
                };

                shippingProvider = new AustraliaPostShippingProvider("CLIENT_ID",
                            "SECRET",
                    shippingCostCalculator,
                    customsHandlingOptions,
                    insuranceOptions);
                #endregion
            }
            else if (senderCountry == "Sweden")
            {
                #region Swedish Postal Service Shipping Provider
                var shippingCostCalculator = new ShippingCostCalculator(
                    internationalShippingFee: 50,
                    extraWeightFee: 100
                )
                {
                    ShippingType = ShippingType.Express
                };

                var customsHandlingOptions = new CustomsHandlingOptions
                {
                    TaxOptions = TaxOptions.PayOnArrival
                };

                var insuranceOptions = new InsuranceOptions
                {
                    ProviderHasInsurance = true,
                    ProviderHasExtendedInsurance = false,
                    ProviderRequiresReturnOnDamange = false
                };

                shippingProvider = new SwedishPostalServiceShippingProvider("API_KEY",
                    shippingCostCalculator,
                    customsHandlingOptions,
                    insuranceOptions);
                #endregion
            }
            else
            {
                throw new NotSupportedException("No shipping provider found for origin country");
            }
            #endregion

            return shippingProvider;
        }
    }

    public class GlobalExpressShippingFactory : ShippingProviderFactory
    {
        public override ShippingProvider CreateShippingProvider(string senderCountry)
        {
            var provider = new GlobalExpressShippingProvider();
            return provider;
              
        }
    }


}
