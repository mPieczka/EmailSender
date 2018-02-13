using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSender.Models.Products
{
    public class SubjectTextBox : Part, IPart
    {
        private const PartType type = PartType.Subject;
        public PartType GetPartType()
        {
            return type;
        }
    }
}