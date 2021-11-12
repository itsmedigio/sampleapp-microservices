using Microsoft.EntityFrameworkCore;

namespace book_microservice.Models
{
    public interface IBookContext
    {
        DbSet<Author> Authors { get; set; }
        DbSet<Book> Books { get; set; }
    }
}