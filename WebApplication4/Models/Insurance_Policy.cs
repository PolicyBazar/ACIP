using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Insurance_Policy
    {
        public int Insurance_Id { get; set; }
        public string vechicle_type { get; set; }
        public int vechicle_cc { get; set; }
        public int Payable_Amount { get; set; }
        public int Maximum_Claim_Amount { get; set; }
    }
}