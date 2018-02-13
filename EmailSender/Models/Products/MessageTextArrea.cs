using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSender.Models.Products
{
    public class MessageTextArrea : Part, IPart
    {
        private const PartType type = PartType.Message;
        public PartType GetPartType()
        {
            return type;
        }
    }
}