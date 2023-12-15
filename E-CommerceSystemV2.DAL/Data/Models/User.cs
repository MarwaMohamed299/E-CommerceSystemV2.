using Microsoft.AspNetCore.Identity;

namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class User : IdentityUser
    {
       
      //  public string Password { get; set; } = string.Empty;

        public DateTime CreationDate { get; set; } = DateTime.Now;

        //navprop
        public ICollection<UserOrders> UserOrders { get; set; } = new HashSet<UserOrders>();





    }
}
