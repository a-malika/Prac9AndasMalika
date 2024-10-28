using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class ExternalLogisticsServiceA
    {
        public void ShipItem(int itemId)
        {
            Console.WriteLine($"Fulfilling a delivery order {itemId} via external logistic service A");
        }
        public string TrackShipment(int shipmentId)
        {
            return "processing via external logistic service A...";
        }
    }
}
