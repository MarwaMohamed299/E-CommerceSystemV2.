using E_CommerceSystemV2.DAL.Repos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IProductRepo? ProductRepo { get; }
        Task<int> saveChangesAsync();
    }
}
