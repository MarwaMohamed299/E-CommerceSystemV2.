using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }

        //NavProp

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
