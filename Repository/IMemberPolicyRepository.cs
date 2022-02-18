using MemberService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberService.Repository
{
    public interface IMemberPolicyRepository
    {
        public List<MemberPolicy> GetPolicies();
    }
}
