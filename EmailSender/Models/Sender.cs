using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
namespace EmailSender.Models
{
    public class Sender
    {
        public bool Send(IEmail email)
        {
            MailMessage mail = new MailMessage(email.GetSender(), email.GetRecipient());
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            mail.Subject = email.GetSubject();
            mail.Body = email.GetMessage();
            for(int i=0;i<email.GetAttachments().Count;i++)
            {
                mail.Attachments.Add(new Attachment(email.GetAttachments().ElementAt(i)));
            }
            client.Send(mail);
            return false;
        }
    }
}