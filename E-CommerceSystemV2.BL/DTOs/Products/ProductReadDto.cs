﻿namespace E_CommerceSystemV2.BL.DTOs.Products
{
    public class ProductReadDto
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
