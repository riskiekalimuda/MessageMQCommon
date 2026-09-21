using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.MQ.Messages.OrderMsv
{
    public class UpdateOrderResultMessage
    {
        public string OrderNumber { get; set; } = string.Empty; 
        public string UpdateOrderResult { get; set; } = string.Empty; 
    }
}
