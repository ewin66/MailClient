using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.MailClient.Win.Helpers.Email
{
    public class EmailSender
    {
        public EmailSender()
        {

        }

        public void Send(MailMessage message)
        {
            try
            {
                SmtpClient client = new SmtpClient(host: "smtp.gmail.com", port: 587);
               
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("silentbusters@gmail.com", "silent123");
                client.Send(message);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
