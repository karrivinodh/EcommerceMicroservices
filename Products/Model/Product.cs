﻿using System;

namespace Products.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; } 
        public Productcategory ProductCategory { get; set; } = new Productcategory();
        public Offer Offer { get; set; } = new Offer();
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ImageName { get; set; }
    }
}
