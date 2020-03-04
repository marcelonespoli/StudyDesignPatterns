using System;

namespace InvoiceAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var adapter = new Invoice(new InvoiceAdapter());
            adapter.PrintInvoice();

            Console.Read();
        }
    }

    public interface IInvoice
    {
        void PrintInvoice();
    }

    public class Invoice
    {
        private readonly IInvoice _invoice;

        public Invoice(IInvoice invoice)
        {
            _invoice = invoice;
        }

        public void PrintInvoice()
        {
            _invoice.PrintInvoice();
        }
    }

    public class InvoicePdf
    {
        public void SaveInvoicePdf()
        {
            Console.WriteLine("Invoice saved in PDF");
        }
    }

    public class InvoiceAdapter : InvoicePdf, IInvoice
    {
        public void PrintInvoice()
        {
            SaveInvoicePdf();
        }
    }
}
