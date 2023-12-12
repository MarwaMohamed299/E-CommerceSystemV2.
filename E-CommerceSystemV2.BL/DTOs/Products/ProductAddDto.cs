using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.BL.DTOs.Products
{
    public class ProductAddDto
    {
        public int ProductId { get;  }
        public int CategoryId { get; set; }

        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
