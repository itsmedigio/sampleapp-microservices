using System.ComponentModel.DataAnnotations;

namespace user_microservice.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FiscalCode { get; set; }
    }
}
