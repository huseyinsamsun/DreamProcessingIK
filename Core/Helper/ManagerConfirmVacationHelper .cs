using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helper
{
    public static class ManagerConfirmVacationHelper
    {
        public static void ManagerConfirmEmail(string email)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("mail.photographybella.com");
            mail.From = new MailAddress("boost@photographybella.com");
            mail.To.Add(email);
            mail.Subject = $"Tebrikler !";
            mail.Body += $"<h2> Tebrikler izniniz kabul edilmiştir. </h2>";
            mail.IsBodyHtml = true;
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential("boost@photographybella.com", "45526201Co");
            smtpClient.Send(mail);
        }
    }
}
