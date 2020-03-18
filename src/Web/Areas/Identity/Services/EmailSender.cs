using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Web.Areas.Identity.Services
{
    public class EmailSender : IEmailSender
    {
        public EmailSender()
        {
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {

            SmtpClient client = new SmtpClient("mysmtpserver");
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("username", "password");

            MailMessage mailMessage = new MailMessage()
            {
                From = new MailAddress("whoever@me.com"),
                Subject=subject,
                Body=htmlMessage,
            };
            mailMessage.To.Add("receiver@me.com");
            return client.SendMailAsync(mailMessage);
        }
    }
}
