using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberService.Models
{
    public class MemberPolicy
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int PolicyId { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public int TopUpFrequency { get; set; }
    }
}
