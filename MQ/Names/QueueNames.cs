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
            public static readonly string AddOrderResultQueue = "add-order-result-queue";
        }  
        public static class PurchaseQueue
        {
            public static readonly string PurchaseCreatedQueue = "purchase-created-queue";
        }   
    }
}
