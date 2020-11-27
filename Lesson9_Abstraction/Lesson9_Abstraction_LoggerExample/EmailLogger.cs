using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Abstraction_LoggerExample
{
    public class EmailLogger : Logger
    {
        public override void Delete(Guid id)
        {
            Log l = Search(id);
            Logs.Remove(l);
        }

        public override void Log(Log log)
        {
            Logs.Add(log);

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("your_email_address@gmail.com");
                mail.To.Add("yourownemailadrressgoeshere@gmail.com");
                mail.Subject = $"Log Email {log.Date.ToString("dd/MM/yyyy HH:mm:ss")}";
                mail.Body = $"Message: { log.Message}, Date: { log.Date}, Type: { log.Type}, It happened: { log.WhereItHappened}";


                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("your_email_address", "password");
                SmtpServer.EnableSsl = true;


                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {

            }
        }

        public override void MarkAsReviewed(Guid id)
        {
            Log l = Search(id);
            if (l != null)
            {
                l.Reviewed = true;
            }
        }

        public override Log Search(Guid id)
        {
            foreach (Log item in Logs)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
