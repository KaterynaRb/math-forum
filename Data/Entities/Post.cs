namespace Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Author { get; set; }
        public int UserId { get; set; }
        public IEnumerable<PostReply> PostReplies { get; set; }
    }
}
