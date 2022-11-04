using MathCornerForum_aspnetcore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MathCornerForum_aspnetcore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                context.Users.Add(new User { UserName = "NewUser", Password = "1234" });
                context.SaveChanges();
            }
        }
    }
}
