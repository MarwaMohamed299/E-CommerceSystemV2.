using E_CommerceSystemV2.API;
using E_CommerceSystemV2.DAL.Repos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        public IProductRepo? ProductRepo { get; }
        private readonly ECommerceContext _ecommerceContext;

        public UnitOfWork(ECommerceContext eCommerceContext,
                            IProductRepo productRepo)
        {
            _ecommerceContext = eCommerceContext;
            ProductRepo = productRepo;
        }

        public async Task<int> saveChangesAsync() => await _ecommerceContext.SaveChangesAsync();

    }
}
