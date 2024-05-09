using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingClient.Models
{
    public class Conversation
    {
        public string? Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public List<User>? Users { get; set; } = new List<User>();
        public List<Message>? ReceivedMessages { get; set; } = new List<Message>();
    }
}