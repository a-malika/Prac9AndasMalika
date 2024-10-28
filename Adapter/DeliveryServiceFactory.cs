using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class DeliveryServiceFactory
    {
        public IInternalDeliveryService GetDeliveryService()
        {
            while (true)
            {
                Console.WriteLine("Which service do you need? (1 - internal, 2 - external A, 3 - external B, 4 - external C)");
                int ans = Convert.ToInt32(Console.ReadLine());
                switch (ans)
                {
                    case 1:
                        return new InternalDeliveryService();
                    case 2:
                        return new LogisticsAdapterA(new ExternalLogisticsServiceA());
                    case 3:
                        return new LogisticsAdapterB(new ExternalLogisticsServiceB());
                    case 4:
                        return new LogisticsAdapterC(new ExternalLogisticsServiceC());
                    default:
                        Console.WriteLine("Incorrect input. Try again.");
                        break;
                }
            }
        }
    }
}
