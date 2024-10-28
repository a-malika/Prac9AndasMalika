using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class SalesReport : IReport
    {
        public string Generate()
        {
            return "Sales Report";
        }
    }
}
