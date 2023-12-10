using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Data.Models
{
   public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }

        public decimal Price { get; set; }

        //NavProp

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public ICollection<Tag> Products { get; set; } = new HashSet<Tag>();

    }
}
