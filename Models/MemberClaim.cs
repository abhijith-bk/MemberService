using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberService.Models
{
    public class MemberClaim
    {
        public int ClaimId { get; set; }
        public int MemberId { get; set; }
        public int PolicyId { get; set; }
        public int ProviderId { get; set; }
        public int ClaimAmount { get; set; }
        public enum ClaimStatusDetail
        {
            Pending,
            Approved,
            Reject
        }
        public ClaimStatusDetail ClaimStatus { get; set; }
        public string[] Benefits { get; set; }

    }
}
