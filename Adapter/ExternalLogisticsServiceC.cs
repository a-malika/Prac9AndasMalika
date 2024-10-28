using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class ExternalLogisticsServiceC
    {
        public void SendOrder(string orderId)
        {
            Console.WriteLine($"Fulfilling a delivery order {orderId} via external logistic service C");
        }
        public string CheckOrderStatus(string shipmentId)
        {
            return "processing via external logistic service C...";
        }
        public double GetShippmentCost(string orderId)
        {
            return 180.0;
        }
    }
}
