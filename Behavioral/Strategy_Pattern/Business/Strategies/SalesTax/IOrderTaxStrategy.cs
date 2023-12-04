using Strategy_Pattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Business.Strategies.SalesTax
{
    public interface IOrderTaxStrategy
    {
        public decimal GetTax(Order order);
    }
}
