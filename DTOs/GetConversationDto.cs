using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessagingClient.Models;

namespace MessagingClient.DTOs
{
    public class GetConversationDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public List<GetConversationUserDto>? Users { get; set; }
        public List<GetMessageDto>? ReceivedMessages { get; set; }
    }
}