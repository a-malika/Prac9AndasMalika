using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class LogisticsAdapterA : IInternalDeliveryService
    {
        private ExternalLogisticsServiceA externalA;
        public LogisticsAdapterA(ExternalLogisticsServiceA externalA)
        {
            this.externalA = externalA;
        }
        public void DeliverOrder(string orderId)
        {
            try
            {
                externalA.ShipItem(int.Parse(orderId));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LogisticsAdapterA (DeliverOrder): {ex.Message}");
            }
        }
        public string GetDeliveryStatus(string orderId)
        {
            try
            {
                return externalA.TrackShipment(Convert.ToInt32(orderId));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LogisticsAdapterA (GetDeliveryStatus): {ex.Message}");
                return "Error";
            }
        }
        public double GetDeliveryCost(string orderId)
        {
            return 150.0;
        }
    }
}
