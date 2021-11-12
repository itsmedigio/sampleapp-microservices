using Microsoft.EntityFrameworkCore;

namespace borrow_microservice.Models
{
    public interface IBorrowContext
    {
        DbSet<Borrow> Borrows { get; set; }
    }
}