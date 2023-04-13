﻿namespace Belajar.Models
{
    public class ProductUpdateModel
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public string BrandId { get; set; } = "";
    }
}
