using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberService.Models;

namespace MemberService.Repository
{
    public class MemberPolicyRepository:IMemberPolicyRepository
    {
        public static List<MemberPolicy> policyList = new List<MemberPolicy>()
        {
            new MemberPolicy()
            {
             MemberId=1,
             MemberName="Ajay",
             PolicyId=1,
             SubscriptionDate=new(2022,2,2),
             LocationId=1,
             LocationName="Mysore",
             HospitalId=1,
             HospitalName="Apollo",
             TopUpFrequency=1
            },
             new MemberPolicy()
            {
             MemberId=2,
             MemberName="Deep",
             PolicyId=2,
             SubscriptionDate=new(2022,1,25),
             LocationId=2,
             LocationName="Dehli",
             HospitalId=2,
             HospitalName="Eden",
             TopUpFrequency=2
            },
              new MemberPolicy()
            {
             MemberId=3,
             MemberName="Varun",
             PolicyId=3,
             SubscriptionDate=new(2022,1,19),
             LocationId=3,
             LocationName="Banglore",
             HospitalId=1,
             HospitalName="Apollo",
             TopUpFrequency=1
            },

        };
        public List<MemberPolicy> GetPolicies()
        {
            return policyList;
        }

    }
}


