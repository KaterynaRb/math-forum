namespace MathCornerForum_aspnetcore.Models.Entities
{
    public class PostReply
    {
        public int Id { get; set; } //PK
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Author { get; set; }
        public int UserId { get; set; } //FK
        public Post Post { get; set; }
        public int PostId { get; set; } //FK
    }
}
