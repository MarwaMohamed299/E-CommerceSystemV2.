using E_CommerceSystemV2.API;
using E_CommerceSystemV2.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Repos.Products
{
    public class ProductRepo:IProductRepo
    {
        private readonly ECommerceContext _ecommerceContext;

        public ProductRepo(ECommerceContext EcommerceContext)
        {
            _ecommerceContext = EcommerceContext;
        }

        public async Task<IEnumerable<Product>> GetAll(int page , int countPerPage)
        {
            //return await _ecommerceContext.Products
            //    .Where(P => P.Name)
            //    .OrderBy(P => P.Price).
            //    Skip((page - 1) * countPerPage)
            //    .Take(countPerPage).
            //    ToListAsync();

            return await _ecommerceContext.Products
                 .OrderBy(P => P.Price)
                 .Skip((page - 1) * countPerPage)
                 .Take(countPerPage)
                 .ToListAsync();



        }

        public async Task<int>GetCount()
        {
            return await _ecommerceContext.Products
                .CountAsync();

        }
        public async Task<Product?> GetById(int productId)
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

       


    }
}
