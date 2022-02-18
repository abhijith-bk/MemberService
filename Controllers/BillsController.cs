using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberService.Models;
using MemberService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MemberService.Controllers
{
 //   [Route("api/[controller]")]
    [ApiController]
    public class BillsController : ControllerBase
    {
        IMemberPremiumRepository _memberPremiumRepository;
        IMemberDetailsRepository _memberDetailsObj;
        public BillsController(IMemberPremiumRepository memberPremiumRepository, IMemberDetailsRepository memberDetailsObj)
        {
             _memberPremiumRepository=memberPremiumRepository;
            _memberDetailsObj = memberDetailsObj;
        }


        [HttpGet]
        [Route("api/[controller]/[action]")]
        public IActionResult Get()
        {
            try
            {
                List<MemberDetails> memberDetails = _memberDetailsObj.GetMemberDetails();
                return Ok(memberDetails);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        [Route("api/[controller]/[action]/{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                List<MemberPremium> memList = _memberPremiumRepository.ViewBills();
                MemberPremium member = memList.FirstOrDefault(x => x.MemberId == id);
                if (member == null)
                    return Ok();
                return Ok(member);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
