using Microsoft.EntityFrameworkCore;

namespace user_microservice.Models
{
    public interface IUserContext
    {
        DbSet<User> Users { get; set; }
    }
}