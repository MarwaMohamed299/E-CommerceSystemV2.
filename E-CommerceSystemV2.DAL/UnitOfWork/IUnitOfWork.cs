using E_CommerceSystemV2.DAL.Repos.Products;

namespace E_CommerceSystemV2.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IProductRepo? ProductRepo { get; }
        Task<int> saveChangesAsync();
    }
}
