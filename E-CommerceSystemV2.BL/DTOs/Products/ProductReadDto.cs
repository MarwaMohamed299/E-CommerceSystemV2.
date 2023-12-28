namespace E_CommerceSystemV2.BL.DTOs.Products
{
    public class ProductReadDto
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Guid TagId { get; set; }
    }
}
