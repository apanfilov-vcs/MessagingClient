using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class GetUserDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public List<GetUserConversationDto> Conversations { get; set; } = new List<GetUserConversationDto>();
    }
}