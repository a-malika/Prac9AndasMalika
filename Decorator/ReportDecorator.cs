using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public abstract class ReportDecorator : IReport
    {
        private IReport report;
        public ReportDecorator(IReport report)
        {
            this.report = report;
        }
        public virtual string Generate()
        {
            return report.Generate();
        }
    }
}
