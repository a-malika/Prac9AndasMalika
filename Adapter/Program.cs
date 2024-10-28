using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DeliveryServiceFactory factory = new DeliveryServiceFactory();
            IInternalDeliveryService deliveryService = factory.GetDeliveryService();
            string orderId = "10207409";
            deliveryService.DeliverOrder(orderId);
            Console.WriteLine($"Status of delivery: {deliveryService.GetDeliveryStatus(orderId)}");
            Console.WriteLine($"Cast of delivery: {deliveryService.GetDeliveryCost(orderId)}");
        }
    }
}
