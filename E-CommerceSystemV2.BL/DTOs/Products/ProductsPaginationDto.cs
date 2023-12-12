using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.BL.DTOs.Products
{
    public class ProductPagintationDto
    {
        public IEnumerable<ProductReadDto> Items { get; set; } = new HashSet<ProductReadDto>();
        public  int TotalCount { get; set; }
    }
}
