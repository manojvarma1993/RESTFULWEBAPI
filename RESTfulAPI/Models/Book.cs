using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulAPI.Models
{
    public class Book
    {
        public  int BookId { get; set; }
        public string BookName { get; set; }
        public Author Author { get; set; }
    }
}
