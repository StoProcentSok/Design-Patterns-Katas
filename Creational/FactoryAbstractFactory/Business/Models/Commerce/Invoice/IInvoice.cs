using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_First_Look.Business.Models.Commerce.Invoice
{
    public interface IInvoice
    {
        public byte[] GenerateInvoice();

    }

    public class GSTInvoice : IInvoice
    {
        public byte[] GenerateInvoice()
        {
            return Encoding.Default.GetBytes("Hello from GST Invoice");
        }
    }

    public class VATInvoice : IInvoice
    {
        public byte[] GenerateInvoice()
        {
            throw new NotImplementedException();
        }
    }

    public class NoVatInvoice : IInvoice
    {
        public byte[] GenerateInvoice()
        {
            throw new NotImplementedException();
        }
    }
}
