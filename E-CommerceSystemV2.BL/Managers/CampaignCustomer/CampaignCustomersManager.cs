using E_CommerceSystemV2.BL.DTOs.CampaignCustomers;
using E_CommerceSystemV2.BL.Services.MailService;
using E_CommerceSystemV2.DAL.Repos.CampaignsCustomers;
using Hangfire;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.BL.Managers.CampaignCustomer
{
    public class CampaignCustomersManager : ICampaignCustomerManager
    {
        private readonly MailingService _mailingService;
        private readonly ICampaignsCustomersRepo _campaignsCustomersRepo;

        public CampaignCustomersManager(MailingService mailingService, ICampaignsCustomersRepo campaignCustomerRepo)
        {
            _mailingService = mailingService;
            _campaignsCustomersRepo = campaignCustomerRepo;
        }
        public void SendingMailsRecurrently()
        {
            RecurringJob.AddOrUpdate(Guid.NewGuid().ToString(),() => SendingEmailsForNewCustomers(), Cron.Hourly);

        }
        public async Task SendingEmailsForNewCustomers()
        {
            try
            {

                var customers = await _campaignsCustomersRepo.GetCustomersEmails();

                foreach (var customer in customers)
                {
                    var toEmail = customer.Email;
                    var subject = "Welcome to SwiftCart!";
                    var message = $"Dear Customer, welcome to our SwiftCart platform!";

                    await _mailingService.SendEmail(subject, toEmail, "Customer", message);

                }
            }
            catch(Exception ex)
            {
                     Log.Error(ex,"Error in sending Emails toThe Customers");

            }
        }
    }
}
