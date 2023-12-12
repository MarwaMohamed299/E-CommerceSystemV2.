using E_CommerceSystemV2.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Repos.Products
{
    public interface IProductRepo
    {
        Task<IEnumerable<Product>> GetAll(int page , int CountPerPage);
        Task<int> GetCount();
        Task<Product?> GetById(int productId);

        Task Add(Product Product);
        Task Update(Product product);
        Task Delete(Product product);
        int SaveChangesAsync();
    }
}
