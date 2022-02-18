using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberService.Models;

namespace MemberService.Repository
{
  public interface IMemberClaimRepository
    {
        public string[] submitClaim(int MemberId,int PolicyId,int ClaimId);
        public List<MemberClaim> GetClaimStatus();

    }
}
