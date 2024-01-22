using E_CommerceSystemV2.API;
using E_CommerceSystemV2.DAL.Data.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Repos.Users
{
    public class UserRepo:IUserRepo
    {
        private readonly ECommerceContext _ecommerceContext;

        public UserRepo(ECommerceContext ecommerceContext )
        {
            _ecommerceContext = ecommerceContext;
        }
        
      public async Task<User?> GetUserDetailsById(string id)
        {
            var user = await _ecommerceContext.Users.FindAsync(id);
            return user;
        }
    }
}
