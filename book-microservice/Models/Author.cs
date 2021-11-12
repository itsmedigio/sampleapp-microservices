using System;
using System.ComponentModel.DataAnnotations;

namespace book_microservice.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}