﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }


        public Product() { }

        public Product(string title, decimal price, string imageUrl, int productId)
        {
            Title = title;
            Price = price;
            ImageUrl = imageUrl;
            ProductId = productId;
        }
    }
}