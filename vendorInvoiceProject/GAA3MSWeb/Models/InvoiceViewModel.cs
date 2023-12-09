using VendorInvoicing.Entities;

namespace GAA3MSWeb.Models
{
    public class InvoiceViewModel
    {
        public Vendor activeVendor { get; set; }

        public int selectedInvoiceId { get; set; }

        public List<Invoice> invoices { get; set; }

        public List<InvoiceLineItem> InvoiceLineItems { get; set; }

        public PaymentTerms? paymentTerms { get; set; }

    }
}