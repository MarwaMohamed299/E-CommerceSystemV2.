using E_CommerceSystemV2.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Repos.CampaignsCustomers;

public interface ICampaignsCustomersRepo
{
    Task<IEnumerable<CampaignCustomers>> GetCustomersEmails();
}
