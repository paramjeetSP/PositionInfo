using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PositionInfo.BAL
{
    public class SendMail
    {
        private Logging _logging = new Logging();
        public async Task<bool> sendEmail(string ReceiverEmail, string RandomCode, string receiverFullName)
        {
            try
            {
                string body = "Dear " + receiverFullName + ", <br><br>Please find Authentication code for Mobile Application - LMS<br><br><b>" + RandomCode + "</b><br><br>Regards,<br><br> LTS Team";
                //SmtpClient client = new SmtpClient("smtp.gmail.com");
                //client.UseDefaultCredentials = false;
                //client.Credentials = new NetworkCredential("softprodigy.testing@gmail.com", "softprodigy123");
                //MailMessage mailMessage = new MailMessage();
                //mailMessage.From = new MailAddress("donotreply@softprodigy.com");
                //mailMessage.To.Add("akash_vashista@softprodigy.com");
                //mailMessage.Body = body;
                //mailMessage.IsBodyHtml = true;
                //mailMessage.Subject = "LMS-MobileApp Authentication Code";
                //await client.SendMailAsync(mailMessage);
                var smtpClient = new SmtpClient
                {
                    Host = "smtp.gmail.com", // set your SMTP server name here
                    Port = 587, // Port 
                    EnableSsl = true,
                    Credentials = new NetworkCredential("softprodigy.testing@gmail.com", "softprodigy12345")
                };

                using (var message = new MailMessage("do-not-reply@softprodigy.com", ReceiverEmail)
                {
                    Subject = "LMS-MobileApp Authentication Code",
                    IsBodyHtml = true,
                    Body = body
                })
                {
                    await smtpClient.SendMailAsync(message);
                }
                return true;
            }
            catch(Exception ex)
            {
                _logging.LogToDb(ex, "sendEmail", "Web/API");
                return false;
            }
        }

    }
}
