using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MemberService.Models;

namespace MemberService.Repository
{
    public class MemberClaimRepository:IMemberClaimRepository
    {
        public static List<MemberClaim> claimDetailsList = new List<MemberClaim>()
        {
            new MemberClaim
            {
                ClaimId = 1,
                MemberId = 1,
                PolicyId =1,
                ProviderId =1,
                ClaimAmount = 1000000,
                ClaimStatus = MemberClaim.ClaimStatusDetail.Pending,
                Benefits = new string[]{
                                 "Medical Bills: Coverage against medicinal expenses incurred, including pre and post hospitalization",
                                "Tax benefits are subject to changes in tax laws",
                                "Claim Reimbursement: Coverage for expenses incurred for hospitalization due to a medical",
                           }


            },

            new MemberClaim
            {
                ClaimId = 2,
                MemberId = 2,
                PolicyId =2,
                ProviderId =2,
                ClaimAmount = 5000000,
                ClaimStatus = MemberClaim.ClaimStatusDetail.Reject,
                 Benefits = new string[]{
                                 "Medical Bills: Coverage against medicinal expenses incurred, including pre and post hospitalization",
                                "Tax benefits are subject to changes in tax laws",
                                "Claim Reimbursement: Coverage for expenses incurred for hospitalization due to a medical",
                           }
            },
            new MemberClaim
            {
                ClaimId = 3,
                MemberId = 3,
                PolicyId =3,
                ProviderId =3,
                ClaimAmount = 3000000,
                ClaimStatus = MemberClaim.ClaimStatusDetail.Approved,
                  Benefits = new string[]{
                                 "Medical Bills: Coverage against medicinal expenses incurred, including pre and post hospitalization",
                                "Tax benefits are subject to changes in tax laws",
                                "Claim Reimbursement: Coverage for expenses incurred for hospitalization due to a medical",
                           }
            }
        };

        public string[] GetClaimStatus(int ClaimId, int PolicyId, int MemberId)
        {
            throw new NotImplementedException();
        }

        public List<MemberClaim> GetClaimStatus()
        {
            return claimDetailsList;
        }

        public string[] submitClaim(int MemberId, int PolicyId, int ClaimId)
        {
            throw new NotImplementedException();
        }
    }
}
