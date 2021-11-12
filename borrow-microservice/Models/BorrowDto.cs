using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace borrow_microservice.Models
{
    public class BorrowDto
    {
        public string BookName { get; set; }
        public string BookDescription { get; set; }
        public string Author { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
