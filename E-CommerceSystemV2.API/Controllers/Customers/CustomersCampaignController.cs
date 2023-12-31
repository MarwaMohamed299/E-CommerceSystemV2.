﻿using E_CommerceSystemV2.BL.Managers.CampaignCustomer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace E_CommerceSystemV2.API.Controllers.Customers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersCampaignController : ControllerBase
    {
        private readonly ICampaignCustomerManager _campaignsCustomerManager;

        public CustomersCampaignController(ICampaignCustomerManager campaignCustomerManager)
        {
            _campaignsCustomerManager = campaignCustomerManager;
        }

        [HttpPost ("send-Emails")]
        public async Task <IActionResult> SendEmails()
        {
         
               await _campaignsCustomerManager.SendingEmailsForNewCustomers();

                return Ok("Email sending job scheduled successfully.");
           
        }
    }
}
