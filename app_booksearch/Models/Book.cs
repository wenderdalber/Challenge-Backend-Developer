using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_booksearch.Models
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public specifications specifications { get; set; }
    }

    public class specifications
    {
        public string OriginallyPublished { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string[] Illustrator { get; set; }
        public string[] Genres { get; set; }
    }
}
