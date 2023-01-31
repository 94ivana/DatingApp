namespace API.Helpers
{
    public class LikesParams : PagnationParams
    {
        public int UserId { get; set; }

        public string Predicate { get; set; }
    }
}