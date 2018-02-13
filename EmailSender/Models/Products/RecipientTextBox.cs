using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSender.Models.Products
{
    public class RecipientTextBox : Part, IPart
    {
        private const PartType type = PartType.Recipent;
        public PartType GetPartType()
        {
            return type;
        }
    }
}