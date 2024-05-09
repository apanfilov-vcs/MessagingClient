using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingClient.Models
{
    public class Message
    {
        public string? Id { get; set; }
        public Conversation? ToConversation { get; set; }
        public User? FromUser { get; set; }
        public string? Contents { get; set; } = string.Empty;
        public DateTime? TimeSent { get; set; }
    }
}