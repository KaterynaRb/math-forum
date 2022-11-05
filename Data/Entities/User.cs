namespace Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] Picture { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<PostReply> PostReplies { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
