using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.MQ.Messages.OrderMsv
{
    public class OrderResultMessage
    {
        public string OrderNumber { get; set; } = string.Empty; 
        public string OrderResult { get; set; } = string.Empty; 
    }
}
