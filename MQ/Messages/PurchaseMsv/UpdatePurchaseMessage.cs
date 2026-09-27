using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.MQ.Messages.PurchaseMsv
{
    public class UpdatePurchaseMessage
    {
        public Guid Id { get; set; }

        public string PurchaseNumber { get; set; } = null!;

        public Guid SupplierId { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = null!;

        public List<UpdatePurchaseDetail> ListUpdatePurchaseDetails { get; set; } = new List<UpdatePurchaseDetail>();
    }
    public class UpdatePurchaseDetail
    {
        public Guid Id { get; set; }

        public Guid PurchaseId { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal? TotalPrice { get; set; }
    }
}
