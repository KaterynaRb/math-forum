using System.ComponentModel.DataAnnotations;

namespace MathCornerForum_aspnetcore.Models
{
    public class UserCreateModel
    {
        //public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public byte[] Picture { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ConfirmEmail { get; set; }
    }
}
