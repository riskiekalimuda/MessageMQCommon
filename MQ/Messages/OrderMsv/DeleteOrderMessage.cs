using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.MQ.Messages.OrderMsv
{
    public class DeleteOrderMessage
    {
        public Guid id { get; set; }
        public List<DeleteOrderDetails> ListDeleteOrderDetails { get; set; } = new List<DeleteOrderDetails>();
    }

    public class DeleteOrderDetails
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public int Qty { get; set; }    
    }
}
