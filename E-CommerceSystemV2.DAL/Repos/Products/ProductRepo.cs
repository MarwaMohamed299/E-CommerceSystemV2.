using Azure;
using E_CommerceSystemV2.API;
using E_CommerceSystemV2.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceSystemV2.DAL.Repos.Products
{
    public class ProductRepo : IProductRepo
    {
        private readonly ECommerceContext _ecommerceContext;

        public ProductRepo(ECommerceContext EcommerceContext)
        {
            _ecommerceContext = EcommerceContext;
          //  _ecommerceContext.Dispose();
        }
        public async Task<IEnumerable<Product>> GetAll(int page, int countPerPage)
        {
            return await _ecommerceContext.Products
                 .OrderBy(P => P.Price)
                 .Skip((page - 1) * countPerPage)
                 .Take(countPerPage)
                 .ToListAsync();
        }

        public async Task<int> GetCount()
        {
            return await _ecommerceContext.Products
                .CountAsync();

        }
        public async Task<Product?> GetById(Guid productId)
        {
            return await _ecommerceContext.Products.FindAsync(productId);
        }


        public async Task Add(Product product)
        {
            await _ecommerceContext.Products.AddAsync(product);
            await _ecommerceContext.SaveChangesAsync();

        }
        public async Task Update(Product product)
        {
            _ecommerceContext.Products.Update(product);
            await _ecommerceContext.SaveChangesAsync();

        }
        public async Task Delete(Product product)
        {
            _ecommerceContext.Products.Remove(product);
            await _ecommerceContext.SaveChangesAsync();

        }

        public int SaveChangesAsync()
        {
            return _ecommerceContext.SaveChanges();
        }

        public async Task<IEnumerable<Product>> SearchWithTag(Guid tagId)
        {
            // TODO: don't ignore warnings
            // TODO: not efficient
            // TODO: don't use ToLower()
            // TODO: don't search by name, search by id, because name is not unique and id is indexed (faster)
            var q1 = await _ecommerceContext.Set<TagProducts>()
                .TagWith("Marwa")
                .Where(tp => tp.TagId == tagId)
                .Select(tp => tp.Product!)
                .ToListAsync();

            var q2 = await _ecommerceContext.Products
                   .TagWith("Jamal")
                   .Where(p => p.TagProducts
                        .Select(t => t.Tag!.TagId)
                        .Contains(tagId))
                   .ToListAsync();

            return q2;
        }
    }
}

