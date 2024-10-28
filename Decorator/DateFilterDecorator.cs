using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class DateFilterDecorator : ReportDecorator
    {
        public DateFilterDecorator(IReport report) : base(report) { }

        public override string Generate()
        {
            return base.Generate() + " filtered by date";
        }
    }
}
