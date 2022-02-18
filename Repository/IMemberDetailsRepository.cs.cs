﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberService.Models;

namespace MemberService.Repository
{
    public interface IMemberDetailsRepository
    {
        public List<MemberDetails> GetMemberDetails();
    }
       
}
