using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DashBaord
    {
        public DashBaord() { }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public string userId { get; set; }
        public bool IsSupervisor { get; set; }


    }
    public class DashBoardDetails
    {
        public DashBoardDetails() { }

        public int QuoteCount { get; set; }
        public decimal TotalQuotePremium { get; set; }

        public int PendingCount { get; set; }
        public decimal TotalPendingPremium { get; set; }

        public int PaymentPenidngCount { get; set; }
        public decimal TotalPaymentPenidngPremium { get; set; }

        public int RejectedCount { get; set; }
        public decimal TotalRejectedPremium { get; set; }

        public int policiesCount { get; set; }
        public decimal TotalPoliciesPremium { get; set; }
    }

}
