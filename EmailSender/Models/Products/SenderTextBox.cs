using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSender.Models.Products
{
    public class SenderTextBox : Part, IPart
    {
        private const PartType type = PartType.Sender;
        public PartType GetPartType()
        {
            return type;
        }
    }
}