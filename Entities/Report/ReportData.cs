using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Report
{
    public class ReportData
    {
        public string GeneratedReportPath { get; set; }
        public string ReportCode { get; set; }
        public string ReportName { get; set; }
        public bool status { get; set; }
        public string Reason { get; set; }
    }
    public class ReportRequest
    {
        public int ESKAReportCode { get; set; }
        public Int64 ESKAPolicyId { get; set; }
    }

    // Added by Shyam Patil 13 Feb 2026
    public class AppReportRequest
    {
        public string Lang { get; set; }

        [Required(ErrorMessage = "Report Type is required (PolicyDocument/StatementOfAccount/ContributionHistory)")]
        public string ReportType { get; set; }

        [Required(ErrorMessage = "Policy No is required")]
        public string PolicyNo { get; set; }
    }

    public class AppReportResponse
    {
        public bool IsError { get; set; } = true;

        public string Message { get; set; }

        public string FileName { get; set; }

        public string FileType { get; set; }

        public string ReportURl { get; set; }
    }
}
