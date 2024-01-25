namespace E_CommerceSystemV2.BL.DTOs.Products;

public class ProductUpdateDto
{
    public Guid ProductId { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public List<Guid>? TagIds { get; set; }
}
