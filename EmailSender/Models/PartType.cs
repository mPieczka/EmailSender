using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSender.Models
{
    public enum PartType
    {
        Sender,
        Recipent,
        Subject,
        Message,
        Attachment,
        SurveyCheckbox,
        SurveySlider
    }
}