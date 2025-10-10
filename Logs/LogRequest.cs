using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IssuancePortal.Model.Logs
{
    public class LogRequest
    { 
        public string IdentifierName { get; set; }
        public string IdentifierId { get; set; }
        public string ApiUrl { get; set; }
        public string RequestDetails { get; set; }
        public string ResponseDetails { get; set; }
        public Exception Exception { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public string LogType { get; set; }
        public string ApplicationName { get; set; } = "InsurancePortal";
    }
}