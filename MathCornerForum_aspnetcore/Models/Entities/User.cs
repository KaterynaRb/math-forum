namespace MathCornerForum_aspnetcore.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual IEnumerable<PostReply> PostReplies { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
