using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ServicePolicylist
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public List<PolicyList> policyList { get; set; }

    }

    public class PolicyList
    {
        public string POLICYNUMBER { get; set; }
        public string NATIONALID { get; set; }
        public string PRODUCTCODE { get; set; }
        public string PRODUCTNAME { get; set; }
    }



    public class ServicePolicyDetails
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public string QUOTENO { get; set; }
        public string POLICYNUMBER { get; set; }
        public string STATUS { get; set; }
        public string PROPOSALNO { get; set; }
        public DateTime? CREATEDDATE { get; set; }
        public string NATIONALID { get; set; }
        public string PRODUCTCODE { get; set; }
        public DateTime? ISSUEDATE { get; set; }
        public DateTime? EXPIRYDATE { get; set; }
        public string PRODUCTNAME { get; set; }
        public string FREQUENCY { get; set; }
        public string FREQUENCYNAME { get; set; }
        public int? SELECTTERM { get; set; } = 0;
        public decimal? Contribution { get; set; } = 0;
        public decimal? SUMCOVERED { get; set; } = 0;
        public decimal? TotalContribution { get; set; } = 0;
        public decimal? PendingContribution { get; set; } = 0;
    }

    public class ServiceResponse
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public string requestno { get; set; }
    }
    public class ServiceRequest
    {
        public string requestno { get; set; }
       
        public string nationalid { get; set; }
       
        public string policynumber { get; set; }
        public string servicetype { get; set; }
        public string servicename { get; set; }
        public string servicesubtype { get; set; }
        public string oldvalue { get; set; }
        public string newvalue { get; set; }
        public string status { get; set; } = "Open";
        public string remarks { get; set; }
        public string createdby { get; set; }
    }
    public class ServiceByrequestno
    {
        public string requestno { get; set; }
    }
    public class ServiceBynationalid
    {
        public string nationalid { get; set; }
    }
    public class ServiceAllData
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public List<ServiceData> serviceData { get; set; }
    }

    public class ServiceData
    {
        public int id { get; set; }
        public string requestno { get; set; }
        public string nationalid { get; set; }
        public string policynumber { get; set; }
        public string servicetype { get; set; }
        public string servicename { get; set; }
        public string servicesubtype { get; set; }
        public string oldvalue { get; set; }
        public string newvalue { get; set; }
        public string status { get; set; }
        public string remarks { get; set; }
        public bool isactive { get; set; }
        public string createdby { get; set; }
        public DateTime? createddate { get; set; }
        public string updatedby { get; set; }
        public DateTime? updateddate { get; set; }
    }
}
