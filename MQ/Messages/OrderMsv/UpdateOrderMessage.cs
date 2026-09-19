using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.MQ.Messages.OrderMsv
{
    public class UpdateOrderMessage
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; } = string.Empty;

        public Guid CustomerId { get; set; }

        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = string.Empty;

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public List<UpdateOrderDetailMessage> TrxOrdersDetails { get; set; } = new List<UpdateOrderDetailMessage>();
    }

    public class UpdateOrderDetailMessage
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal PricePerUnit { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
