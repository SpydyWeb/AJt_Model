using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class GOTP
    {
        public string SessionId { get; set; }
        public DateTime CreateDate { get; set; }
        public string MobileNo { get; set; }
        public bool OTPisValid { get; set; } = false;
        public bool isOTPGenerated { get; set; } = false;
        public string OTP { get; set; }
    }
}
