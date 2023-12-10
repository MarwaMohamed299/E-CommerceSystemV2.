using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class UserOrder
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }

        //navprop
        public Order? Order { get; set; }
        public User? User { get; set; }



    }
}
