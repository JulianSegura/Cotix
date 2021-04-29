using Cotix.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotix.UI.WinForms.Reports
{
    internal class QuotationReportPrintable
    {

        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerCompany { get; set; }
        public int QuotationNumber { get; set; }
        public int DaysValid { get; set; }
        public string DateCreated { get; set; }
        public List<ReportLine> Lines { get; private set; } = new List<ReportLine>();
        public string SubTotal { get; set; }
        public string TransportationFee { get; set; }
        public string Total { get; set; }

        public QuotationReportPrintable(Quotation q)
        {
            CustomerName = q.Customer.Name;
            CustomerPhone = q.Customer.PhoneNumber;
            CustomerEmail = q.Customer.Email;
            CustomerCompany = q.Customer.Company;
            QuotationNumber = q.Id;
            DaysValid = (q.ValidUntil.Date - q.CreatedAt.Date).Days;
            DateCreated = q.CreatedAt.Date.ToString("dd-MMMM-yyyy");
            SubTotal = $"{q.SubTotal:C}";
            TransportationFee = $"{q.TransportationFee:c}";
            Total = $"{q.Total:c}";

            for (int i = 0; i < q.Details.Count; i++)
            {
                var detail = q.Details.ElementAt(i);
                Lines.Add(new ReportLine
                {
                    LineNo = i + 1,
                    ProductCode = detail.Product.Code,
                    ProductDescription = detail.Product.Description,
                    PicturePath = new Uri(detail.Product.PicturePath).AbsoluteUri,
                    Qty = detail.Quantity,
                    UnitPrice = $"{detail.Product.Price:C}",
                    LineTotal = $"{detail.Amount:C}"
                }) ;
            }
        }
    }

    internal class ReportLine
    {
        public int LineNo { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string PicturePath { get; set; }
        public int Qty { get; set; }
        public string UnitPrice { get; set; }
        public string LineTotal { get; set; }
    }
}
