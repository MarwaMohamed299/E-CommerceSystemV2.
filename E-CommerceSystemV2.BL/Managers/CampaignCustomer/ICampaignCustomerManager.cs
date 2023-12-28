using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_CommerceSystemV2.BL.DTOs.CampaignCustomers;

namespace E_CommerceSystemV2.BL.Managers.CampaignCustomer
{
    public interface ICampaignCustomerManager
    {
        public  Task SendingEmailsForNewCustomers();
    }
}
