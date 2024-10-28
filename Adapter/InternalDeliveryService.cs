using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class InternalDeliveryService : IInternalDeliveryService
    {
        public void DeliverOrder(string orderId)
        {
            Console.WriteLine($"Fulfilling a delivery order {orderId}");
        }
        public string GetDeliveryStatus(string orderId)
        {
            return "processing...";
        }
        public double GetDeliveryCost(string orderId)
        {
            return 100.0;
        }
    }
}
