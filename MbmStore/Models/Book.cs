using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }

        public Book() { }

        public Book(string author, short published, string title, decimal price, string imageUrl, int productId) : base(title, price, imageUrl, productId)
        {
            Author = author;
            Published = published;
        }
    }
}