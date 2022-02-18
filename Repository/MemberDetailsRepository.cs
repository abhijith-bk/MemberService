using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberService.Models;

namespace MemberService.Repository
{
    public class MemberDetailsRepository : IMemberDetailsRepository
    {
        public static List<MemberDetails> memberDetails = new List<MemberDetails>()
        {
            new MemberDetails()
            {
             MemberId=1,
             MemberName="Abhijeet",
             PhoneNumber = "9876543210",
             Gender = "Male",
             Place = "Karnatak"
            },

             new MemberDetails()
            {
             MemberId=2,
             MemberName="Deep",
             PhoneNumber = "9876543210",
             Gender = "Male",
             Place = "Madhya Pradesh"
            },

              new MemberDetails()
            {
             MemberId=3,
             MemberName="Dhanashri",
             PhoneNumber = "9876543210",
             Gender = "Female",
             Place = "Pune"
            },
        };
        public List<MemberDetails> GetMemberDetails()
        {
            return memberDetails;
        }
    }
}
//GET: / viewBills(Input: Member_ID, Policy_ID | Output: Last Premium Paid Date, Premium_Amount_Due, Details of Late Payment Charges if applicable, Due Date etc.) 

//GET: / getClaimStatus(Input: Claim_ID, Policy_ID, Member_ID | Output: Claim Status, Claim Status Description)

//POST: / submitClaim(Input: Policy_ID, Member_ID, Claim_Details(Hospital ID, Benefits Availed, Total Billed Amount, Total Claimed Amount) | Output: Claim Status, Claim Status Description) 