using Microsoft.AspNetCore.Identity;

namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class User : IdentityUser
    {
       

        public DateTime CreationDate { get; set; } = DateTime.Now;

        //navprop
        public ICollection<UserOrders> UserOrders { get; set; } = new HashSet<UserOrders>();





    }
}
