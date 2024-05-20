namespace Application.DTOs
{
    public class GetMessageDto
    {
        public string Id { get; set; } = string.Empty;
        public GetMessageConversationDto ToConversation { get; set; } = new GetMessageConversationDto();
        public GetMessageUserDto FromUser { get; set; } = new GetMessageUserDto();
        public string Contents { get; set; } = string.Empty;
        public DateTime TimeSent { get; set; } = DateTime.MinValue;
    }
}