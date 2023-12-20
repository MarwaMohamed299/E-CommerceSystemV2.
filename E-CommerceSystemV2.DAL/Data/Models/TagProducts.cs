using System.ComponentModel.DataAnnotations;

namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class TagProducts
    {
        public Guid ProductId { get; set; }
        public Guid TagId { get; set; }
        public Product? Product { get; set; }
        public Tag? Tag { get; set; }


    }
}
