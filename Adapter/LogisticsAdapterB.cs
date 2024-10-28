using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class LogisticsAdapterB : IInternalDeliveryService
    {
        private ExternalLogisticsServiceB externalB;
        public LogisticsAdapterB(ExternalLogisticsServiceB externalB)
        {
            this.externalB = externalB;
        }
        public void DeliverOrder(string orderId)
        {
            externalB.SendPackage(orderId);
        }
        public string GetDeliveryStatus(string orderId)
        {
            return externalB.CheckPackageStatus(orderId);
        }
        public double GetDeliveryCost(string orderId)
        {
            return 200.0;
        }
    }
}
