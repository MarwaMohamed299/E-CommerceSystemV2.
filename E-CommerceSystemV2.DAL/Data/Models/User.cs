using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string E_mail { get; set; } = string.Empty;
        public string PasswordHashSet { get; set; } = string.Empty;

        public DateTime CreationDate { get; set; } = DateTime.Now;




    }
}
