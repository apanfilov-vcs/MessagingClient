namespace Application.DTOs
{
    public class GetConversationDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<GetConversationUserDto> Users { get; set; } = new List<GetConversationUserDto>();
        public List<GetMessageDto> ReceivedMessages { get; set; } = new List<GetMessageDto>();
    }
}