using Microsoft.EntityFrameworkCore;

namespace user_microservice.Models
{
    public class UserContext : DbContext, IUserContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options) { }

        public virtual DbSet<User> Users { get; set; }
    }
}
