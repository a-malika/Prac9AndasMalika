using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class LogisticsAdapterC : IInternalDeliveryService
    {
        private ExternalLogisticsServiceC externalC;
        public LogisticsAdapterC(ExternalLogisticsServiceC externalC)
        {
            this.externalC = externalC;
        }
        public void DeliverOrder(string orderId)
        {
            externalC.SendOrder(orderId);
        }
        public string GetDeliveryStatus(string orderId)
        {
            return externalC.CheckOrderStatus(orderId);
        }
        public double GetDeliveryCost(string orderId)
        {
            return externalC.GetShippmentCost(orderId);
        }
    }
}
