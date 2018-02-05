using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender.Models
{
    public interface IEmail
    {
        String GetSender();
        String GetRecipient();
        String GetMessage();
        String GetSubject();
        List<String> GetAttachments();
    }
}
