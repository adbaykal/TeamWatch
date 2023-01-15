using MediatR;
using TeamWatch.Domain.Entities;

namespace TeamWatch.Application.Teams.Queries
{
    public class ListMembersCurrentTimeQuery : IRequest<List<Member>>
    {
        public List<Member> MemberList { get; set; }
    }


}
