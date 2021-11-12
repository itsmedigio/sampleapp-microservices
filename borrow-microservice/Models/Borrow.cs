using System;
using System.ComponentModel.DataAnnotations;

namespace borrow_microservice.Models
{
    public class Borrow
    {
        [Key]
        public int BorrowId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
