using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FDashBoard
    {
        public int QuoteNo { get; set; }
        public string Policynumber { get; set; }
        public string Product { get; set; }
        public DateTime RecievedDate { get; set; }
        public string FullName { get; set; }

        public string premium { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public string status { get; set; }
        public string ReferenceNo { get; set; }
        public decimal Amounttransferred { get; set; }
        public decimal TotalPremiumWithVAT { get; set; }
        public decimal TotalPremiumWithoutVAT { get; set; }
        public decimal VAT { get; set; }
        public string Attachments{get;set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string PaymentKey { get; set; }
    }
}
