using app_booksearch.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public bool OrderBy(string order)
        {
            try
            {
                var JSON = System.IO.File.ReadAllText(@"C:\Users\wende\Desktop\bitcoingroup\app_booksearch\app_booksearch\book.json");
                var list = JsonConvert.DeserializeObject<List<Book>>(JSON);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
