﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookAddIn3
{
    public class MailModel
    {
       
        public string MailSubject { get; set; }

        public string MailBody { get; set; }

        public string FromEmail { get; set; }

        public string ToEmail { get; set; }

        public string CcEmail { get; set; }

        public string BccEmail { get; set; }
        public string EntryId { get; set; }
        


    }
}
