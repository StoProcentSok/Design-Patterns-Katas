using Strategy_Pattern.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Business.Strategies.Invoice
{
    internal class EmailInvoiceStrategy : InvoiceStrategy
    {
        public override void GenerateInvoice(Order order)
        {
            //Strategy implementation obtained with use of inheritance and overriden abstract method
        }
    }
}
