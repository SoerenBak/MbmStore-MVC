using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // properties


        public string Director { get; set; }
        public short Released { get; set; }

        // constructors
        public Movie(string title, decimal price, string imageUrl, int productId) :base(title,price,imageUrl,productId)
        {
            
        }

        public Movie(string title, decimal price, string imageUrl, string director, int productId) :base(title,price,imageUrl,productId)
        {
            Director = director;
        }
    }
}