namespace E_CommerceSystemV2.BL.DTOs.Products;

public class ProductAddDto
{
    //   public Guid ProductId { get; }
    //    public Guid CategoryId { get; set; }
    public Guid OrderId { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
}
