namespace E_CommerceSystemV2.BL.DTOs.Products;

public class ProductPagintationDto
{
    public IEnumerable<ProductReadDto> Items { get; set; } = new HashSet<ProductReadDto>();
    public int TotalCount { get; set; }
}
