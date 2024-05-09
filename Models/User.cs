using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingClient.Models
{
    public class User
    {
        public string? Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public List<Conversation>? Conversations { get; set; } = new List<Conversation>();
        public List<Message>? SentMessages { get; set; } = new List<Message>();
    }
}