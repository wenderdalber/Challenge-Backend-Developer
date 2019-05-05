using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using app_booksearch.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace app_booksearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            var JSON = System.IO.File.ReadAllText(@"C:\Users\wende\Desktop\bitcoingroup\app_booksearch\app_booksearch\book.json");
            var list = JsonConvert.DeserializeObject<List<Book>>(JSON);
            return list;
        }

        // GET api/values/asc
        [HttpGet("{order}")]
        public ActionResult<List<Book>> Get(string order)
        {
            var JSON = System.IO.File.ReadAllText(@"C:\Users\wende\Desktop\bitcoingroup\app_booksearch\app_booksearch\book.json");
            var list = JsonConvert.DeserializeObject<List<Book>>(JSON);
            if (order == "asc") { list = list.OrderBy(x => x.price).ToList(); }
            else if (order == "desc") { list = list.OrderByDescending(x => x.price).ToList(); }
            else
            {
                list = list.Where(x => x.name.Contains(order)).ToList();
                if (list.Count == 0)
                {
                    list = list.Where(x => x.specifications.Author.Contains(order)).ToList();
                }
            }
            return list;
        }
    }
}