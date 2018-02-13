using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSender.Models.Products
{
    public abstract class Part
    {
        protected string _content;
        public string GetContent()
        {
            return _content;
        }
    }
}