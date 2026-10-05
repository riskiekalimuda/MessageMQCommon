using MessageMQCommon.MQ.Messages.OrderMsv;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.MQ.Messages.DeliveryMsv
{
    public class DeliveryMessage
    {
        public ApproveOrderMessage ApprovedOrder { get; set; } = null!;
    }

}
