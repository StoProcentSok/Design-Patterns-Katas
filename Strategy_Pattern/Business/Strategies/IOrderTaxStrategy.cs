﻿using Strategy_Pattern_First_Look.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern_First_Look.Business.Strategies
{
    public interface IOrderTaxStrategy
    {
        public decimal GetTax(Order order);
    }
}
