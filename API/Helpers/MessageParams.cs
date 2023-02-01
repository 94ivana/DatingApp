namespace API.Helpers
{
    public class MessageParams : PagnationParams
    {
        public string Username { get; set; }

        public string Container { get; set; } = "Unread";
    }
}