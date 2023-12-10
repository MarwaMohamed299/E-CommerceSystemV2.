using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class TagProducts
    {
        public int ProductId { get; set; }
        public int TagId { get; set; }

        public Product? Product { get; set; }
        public Tag? Tag { get; set; }
             

    }
}
