using System;
using System.Collections.Generic;
using System.Text;

namespace MessageMQCommon.MQ.Names
{
    public static class QueueNames
    {
        public static readonly string OrderCreatedQueue = "order-created";  
        public static class OrderQueue
        {
            public static readonly string AddOrderQueue = "add-order-queue";
        }   
    }
}
