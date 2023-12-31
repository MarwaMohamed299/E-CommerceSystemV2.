using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace E_CommerceSystemV2.BL.Services.MailService
{
    public class MailingService :IMailService
    {
        private readonly string _sendGridApiKey;

        public MailingService(IConfiguration configuration )
        {
            _sendGridApiKey = configuration["SendGrid:ApiKey"]!;
        }
        public async Task SendEmail(string subject, string toEmail, string userName, string message)
        {
            try
            {
                {
                    var apiKey = Environment.GetEnvironmentVariable(_sendGridApiKey); 
                    var client = new SendGridClient(_sendGridApiKey);
                    var from = new EmailAddress("Jamal.Ali.Habashi@gmail.com", "SwiftCart");
                    var to = new EmailAddress(toEmail, userName);
                    var plainTextContent = message;
                    var htmlContent = $@"
                            <p>Dear Customer,</p>
                            <p>Welcome to our  SwiftCart! 🎉</p>
                            <p>Explore a world of amazing products and fantastic deals just for you.</p>
                            <ul>
                                <li>Browse through our diverse catalog</li>
                                <li>Discover exclusive discounts</li>
                                <li>Create a Wishlist of your favorite items</li>
                                <li>and much more!</li>
                            </ul>
                            <p>Ready to start shopping? <a href=""#link_to_your_app"">Visit our app now</a> and experience the joy of online shopping!</p>
                            <p>Thank you for choosing SwiftCart. We look forward to serving you!</p>
                            <p>Best regards,<br/>The SwiftCart Team</p>";
                    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                    var response = await client.SendEmailAsync(msg);
                    if (string.IsNullOrEmpty(_sendGridApiKey))
                    {
                        Log.Error("SendGrid API key is missing or empty.");
                        throw new InvalidOperationException("SendGrid API key is missing or empty.");
                    }
                    Log.Information("Email sent successfully to {ToEmail} with subject: {Subject}", toEmail, subject);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error sending email to {ToEmail} with subject: {Subject}", toEmail, subject);
                throw;
            }
        }
    }
}
