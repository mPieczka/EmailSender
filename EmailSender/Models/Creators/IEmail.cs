using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender.Models
{
    public interface IEmail
    {
        IEmail CombineEmail();
        string GetSender();
        string GetRecipient();
        string GetSubject();
        string GetMessage();
        List<string> GetAttachments();
    }
}
