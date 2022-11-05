using Data.Entities;

namespace MathCornerForum_aspnetcore.Models
{
    public class PostReplyViewModel
    {
        //public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Author { get; set; }
        public Post Post { get; set; }
    }
}
