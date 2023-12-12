using E_CommerceSystemV2.BL.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.BL.Managers.Products
{
    public interface IProductsManager
    {
        Task<IEnumerable<ProductPagintationDto>> GetAll(int page,int countPerPage);
      //  Task<ProductPagintationDto> GetAll(int page, int countPerPage)

        Task<ProductReadDto?> GetById(int productId);
        Task<string> Add(ProductAddDto productAddDto);
        Task<string?> Update(ProductUpdateDto productUpdateDto);
        Task<bool> Delete(int productId);

    }
}
