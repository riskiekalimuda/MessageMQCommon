using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.MQ.Messages
{
    public class OrderCreatedMessage
    {
        public Guid OrderId { get; set; }
        public string CustomerEmail { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
