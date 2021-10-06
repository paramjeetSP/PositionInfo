using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using LeaveManagement.BAL;

namespace LeaveManagement.Helper
{
    public class EmailSend
    {
        private Logging _logging = new Logging();
        public async Task<bool> emailSend(string ReceiverEmail, string RandomCode, string receiverFullName)
        {
            try
            {
                string body = "Dear " + receiverFullName + ", <br><br> Goal setting form has been initiated by HR . kindly Fill the goal setting form.<br><br><b>" + RandomCode + "</b><br><br>Regards,<br><br> Admin";
                var smtpClient = new SmtpClient
                {
                    Host = "smtp.gmail.com", // set your SMTP server name here
                    Port = 587, // Port 
                    EnableSsl = true,
                    Credentials = new NetworkCredential("softprodigy.testing@gmail.com", "softprodigy12345")
                };

                using (var message = new MailMessage("do-not-reply@softprodigy.com", ReceiverEmail)
                {
                    Subject = "GoalSetting Form",
                    IsBodyHtml = true,
                    Body = body
                })
                {

                    await smtpClient.SendMailAsync(message);
                }
                return true;
            }
            catch (Exception ex)
            {
                _logging.LogToDb(ex, "sendEmail", "Web/API");
                return false;
            }
        }
    }
}
