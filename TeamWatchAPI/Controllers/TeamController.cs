using Mapster;
using Microsoft.AspNetCore.Mvc;
using TeamWatch.Domain.Entities;
using TeamWatchAPI.Model;

namespace TeamWatchAPI.Controllers
{
    [Route("api/team")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        [HttpPost]
        [Route("list-member-time")]
        public List<Member> GetMemberListWithCurrentTime(List<MemberDTO> memberList)
        {
            var resultList = new List<Member>();

            foreach (var member in memberList)
            {
                resultList.Add(member.Adapt<Member>());
            }

            return resultList;
        }
    }
}
