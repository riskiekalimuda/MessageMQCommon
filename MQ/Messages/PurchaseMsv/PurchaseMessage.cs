using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.MQ.Messages.PurchaseMsv
{
    public class PurchaseMessage
    {
        public Guid Id { get; set; }
        public string PurchaseNumber { get; set; } = string.Empty;
        public Guid SupplierId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = string.Empty;
        public List<PurchaseDetailMessage> Details { get; set; } = new List<PurchaseDetailMessage>();
    }


    public class PurchaseDetailMessage
    {
        public Guid Id { get; set; }
        public Guid PurchaseId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
    }

}
