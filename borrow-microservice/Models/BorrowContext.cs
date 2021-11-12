using Microsoft.EntityFrameworkCore;

namespace borrow_microservice.Models
{
    public class BorrowContext : DbContext, IBorrowContext
    {
        public BorrowContext(DbContextOptions<BorrowContext> options)
            : base(options) { }

        public virtual DbSet<Borrow> Borrows { get; set; }
    }
}
