using E_CommerceSystemV2.DAL.Data.Models;

namespace E_CommerceSystemV2.DAL.Repos.Products
{
    public interface IProductRepo
    {
        Task<IEnumerable<TagProducts>> GetProductTags();
        Task<IEnumerable<Tag>> UpdateProductTag(Guid productId , List<Guid> tagIds);
        Task<IEnumerable<Product>> SearchWithTag(Guid tagId);
        Task<IEnumerable<Product>> GetAll(int page, int CountPerPage);
        Task<IEnumerable<Product>> SearchWithManyTags(List<Guid> tagIds);
        Task<int> GetCount();
        Task<Product?> GetById(Guid productId);
        Task Add(Product Product);
        Task Update(Product product);
        Task Delete(Product product);
        int SaveChangesAsync();
    }
}
