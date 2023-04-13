﻿namespace BelajarNextJsBackEnd.Models
{
    public class ProductUpdateModel
    {
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string BrandId { get; set; } = "";
    }
}
