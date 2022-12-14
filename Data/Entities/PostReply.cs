namespace Data.Entities
{
    public class PostReply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Author { get; set; }
        public int UserId { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}
