using System;
using System.Collections.Generic;
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
}
