using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.BL.DTOs.Products
{
    public class ProductReadDto
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }

        public decimal Price { get; set; }
    }
}
