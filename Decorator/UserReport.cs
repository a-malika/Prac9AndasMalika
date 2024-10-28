using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class UserReport : IReport
    {
        public string Generate()
        {
            return "User Report";
        }
    }
}
