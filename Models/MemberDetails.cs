using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberService.Models
{
    public class MemberDetails
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Place  { get; set; }
    }
}
