using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.MQ.Messages.PurchaseMsv
{
    public class PurchaseResultMessage
    {
        public string PurchaseNumber { get; set; } = string.Empty;
        public string PurchaseResult { get; set; } = string.Empty;
    }
}
