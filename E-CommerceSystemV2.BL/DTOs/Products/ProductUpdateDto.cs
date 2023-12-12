using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.BL.DTOs.Products
{
    public class ProductUpdateDto
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }

        public decimal Price { get; set; }
    }
}
