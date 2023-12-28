using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.BL.Services.MailService
{
    public interface IMailService
    {
        public Task SendEmail(string subject, string toEmail, string userName, string message);
    }
}
