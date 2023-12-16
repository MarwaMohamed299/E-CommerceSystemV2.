using E_CommerceSystemV2.BL.DTOs.Products;

namespace E_CommerceSystemV2.BL.Managers.Products
{
    public interface IProductsManager
    {
        Task<IEnumerable<ProductPagintationDto>> GetAll(int page, int countPerPage);
        Task<IEnumerable<ProductReadDto>> SearchWithTag(string tag);

        Task<ProductReadDto?> GetById(Guid productId);
        Task<string> Add(ProductAddDto productAddDto);
        Task<string?> Update(ProductUpdateDto productUpdateDto);
        Task<bool> Delete(Guid productId);

    }
}
