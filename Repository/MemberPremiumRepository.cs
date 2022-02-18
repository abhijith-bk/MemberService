using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberService.Models;

namespace MemberService.Repository
{
    public class MemberPremiumRepository : IMemberPremiumRepository
    {
        public static List<MemberPremium> memberList = new List<MemberPremium>()
        {
            new MemberPremium()
            {
             MemberId=1,
             PolicyId=1,
             TopUp=1000,
             PremiumDue=10000,
             PremiumPaymentDetails="Paid",
             PaidDate=new DateTime(2022,01,01)
            },

            new MemberPremium()
            {
             MemberId=2,
             PolicyId=2,
             TopUp=2000,
             PremiumDue=8000,
             PremiumPaymentDetails="Not Paid",
             PaidDate=new DateTime(2000,10,10)
            },
            new MemberPremium()
            {
             MemberId=3,
             PolicyId=3,
             TopUp=1500,
             PremiumDue=12000,
             PremiumPaymentDetails="Paid",
             PaidDate=new DateTime(2022,02,11)
            },


        };
        List<MemberPremium> IMemberPremiumRepository.ViewBills()
        {
            return memberList;
        }
    }
}
