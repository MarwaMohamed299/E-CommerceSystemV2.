using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.BL.DTOs.Products
{
    public class ProductTagsReadDto
    {
        public Guid ProductId{get; set;}
        public string Name { get; set; } = string.Empty;
        public List<Guid> TagIds { get; set; } = new List<Guid>();
    }
}
