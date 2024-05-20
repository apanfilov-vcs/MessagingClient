namespace Application.DTOs
{
    public class GetUserDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public List<GetUserConversationDto> Conversations { get; set; } = new List<GetUserConversationDto>();
    }
}