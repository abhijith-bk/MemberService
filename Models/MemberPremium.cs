using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberService.Models
{
    public class MemberPremium
    {
        public int MemberId { get; set; }
        public int PolicyId { get; set; }
        public int TopUp { get; set; }
        public int PremiumDue { get; set; }
        public string PremiumPaymentDetails { get; set; }
        public DateTime PaidDate { get; set; }
       
    }
}
