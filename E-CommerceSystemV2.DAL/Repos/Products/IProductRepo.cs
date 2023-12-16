using E_CommerceSystemV2.DAL.Data.Models;

namespace E_CommerceSystemV2.DAL.Repos.Products
{
    public interface IProductRepo
    {
        Task<IEnumerable<Product>> SearchWithTag(string tag);
        Task<IEnumerable<Product>> GetAll(int page, int CountPerPage);
        Task<int> GetCount();
        Task<Product?> GetById(Guid productId);

        Task Add(Product Product);
        Task Update(Product product);
        Task Delete(Product product);
        int SaveChangesAsync();
    }
}
