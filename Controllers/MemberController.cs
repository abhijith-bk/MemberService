using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberService.Models;
using MemberService.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MemberService.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
            IMemberClaimRepository _memberClaimObj;
            IMemberPolicyRepository _memberPolicyObj;

        public MemberController(IMemberClaimRepository memberClaimObj, IMemberPolicyRepository memberPolicyObj)
            {
                _memberClaimObj = memberClaimObj;
            _memberPolicyObj = memberPolicyObj;
              
            }

            [HttpGet]
            [Route("api/[controller]/[action]")]
            public IActionResult Get()
            {
                try
                {
                    return Ok(_memberClaimObj.GetClaimStatus());
                }
                catch (Exception exp)
                {
                    return BadRequest();
                }
            }
       
        
        [HttpGet]
        [Route("api/[controller]/[action]")]
        public IActionResult PolicyList()
        {
            try
            {
                return Ok(_memberPolicyObj.GetPolicies());
            }
            catch (Exception exp)
            {
                return BadRequest();
            }
        }






        [HttpGet]
            [Route("api/[controller]/[action]/{id}")]
            public IActionResult Get(int id)
            {
                try
                {
                    List<MemberClaim> claimList = _memberClaimObj.GetClaimStatus();
                    var claim = claimList.FirstOrDefault(x => x.ClaimId == id);
                    if (claim != null)
                        return Ok(claim);
                    else
                        return Ok();

                }
                catch (Exception exp)
                {
                    return BadRequest();
                }
            }

            [HttpPut]
            [Route("api/[controller]/[action]/{id}")]
            public IActionResult Put(int id, string status)
            {
                try
                {
                    List<MemberClaim> claimList = _memberClaimObj.GetClaimStatus();
                    MemberClaim claim = claimList.FirstOrDefault(x => x.ClaimId == id);
                    if (claim != null)
                    {
                        foreach (MemberClaim temp in (_memberClaimObj.GetClaimStatus()))
                        {
                            if (temp.ClaimId == id)
                            {
                                if (status == "Approved")
                                    temp.ClaimStatus = MemberClaim.ClaimStatusDetail.Approved;
                                else
                                    temp.ClaimStatus = MemberClaim.ClaimStatusDetail.Reject;
                                break;
                            }
                        }
                        return Ok(claim.ClaimStatus);
                    }
                    else
                        return Ok("Object null");
                }
                catch (Exception exp)
                {
                    return BadRequest();
                }
            }


        }
    
}