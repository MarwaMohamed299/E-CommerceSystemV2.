using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class UserOrders
    {
        public  int UserId {get; set;}
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public User? User { get; set; }
    }
}
