using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class ExternalLogisticsServiceB
    {
        public void SendPackage(string packageInfo)
        {
            Console.WriteLine($"Fulfilling a delivery order {packageInfo} via external logistic service B");
        }
        public string CheckPackageStatus(string trackingCode)
        {
            return "processing via external logistic service B...";
        }
    }
}
