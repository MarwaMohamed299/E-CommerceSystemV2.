using E_CommerceSystemV2.API;
using E_CommerceSystemV2.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Repos.CampaignsCustomers;

public class CampaignsCustomersRepo : ICampaignsCustomersRepo
{
    private ECommerceContext _ecommerceContext;

    public CampaignsCustomersRepo(ECommerceContext eCommerceContext)
    {
        _ecommerceContext = eCommerceContext;
    }

    public async Task<IEnumerable<CampaignCustomers>> GetCustomersEmails()
    {
        return await _ecommerceContext.CampaignCustomers
                        .Select(t => new CampaignCustomers
                        {
                            Email = t.Email
                        }).ToListAsync();
    }

}
