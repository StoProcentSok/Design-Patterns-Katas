using Factory_Pattern.Business.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_First_Look.Business.Models.Commerce.Summary
{
    public interface ISummary
    {
        string CreateOrderSummary(Order order);
        void Send();
    }

    public class EmailSummary : ISummary
    {
        public string CreateOrderSummary(Order order)
        {
            return "This is email summary";
        }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }

    public class CsVSummary : ISummary
    {
        public string CreateOrderSummary(Order order)
        {
            return "this,is,csv,summary";
        }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}
