using System.ComponentModel.DataAnnotations;

namespace book_microservice.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookDescription { get; set; }
        public double BookPrice { get; set; }
        public Author BookAuthor { get; set; }
    }
}
