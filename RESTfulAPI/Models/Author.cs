using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulAPI.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public  string AuthorName { get; set; }
        public List<Book> BookId { get; set; }
    }
}
