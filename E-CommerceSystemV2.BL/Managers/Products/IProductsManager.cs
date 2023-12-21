using E_CommerceSystemV2.BL.DTOs.Products;

namespace E_CommerceSystemV2.BL.Managers.Products
{
    public interface IProductsManager
    {
        Task<ProductPagintationDto> GetAll(int page, int countPerPage);
        Task<IEnumerable<ProductReadDto>> SearchWithTag(Guid tagId);
        Task<IEnumerable<ProductReadDto>> SearchWithManyTags(List<Guid>tagIds);
        Task<ProductUpdateDto> UpdateProductTag(Guid productId,List<Guid>tagIds);
        Task<ProductReadDto?> GetById(Guid productId);
        Task<string> Add(ProductAddDto productAddDto);
        Task<string?> Update(ProductUpdateDto productUpdateDto);
        Task<bool> Delete(Guid productId);

    }
}
