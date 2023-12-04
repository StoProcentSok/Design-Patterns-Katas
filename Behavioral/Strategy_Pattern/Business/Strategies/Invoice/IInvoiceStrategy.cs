using Strategy_Pattern.Business.Models;

namespace Strategy_Pattern.Business.Strategies.Invoice
{
    public interface IInvoiceStrategy
    {
        public void GenerateInvoice(Order order);
    }
}
