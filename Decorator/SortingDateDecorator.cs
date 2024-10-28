using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class SortingDateDecorator : ReportDecorator
    {
        public SortingDateDecorator(IReport report) : base(report) { }

        public override string Generate()
        {
            return base.Generate() + " sorted by date";
        }
    }
}
