﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharePointWebHooks.Models
{
    public class SPWebhookContent
    {
        public List<SPWebhookNotification> Value { get; set; }
    }
}