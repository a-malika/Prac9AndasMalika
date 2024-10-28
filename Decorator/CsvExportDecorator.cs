using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class CsvExportDecorator : ReportDecorator
    {
        public CsvExportDecorator(IReport report) : base(report) { }

        public override string Generate()
        {
            return base.Generate() + " can export into csv";
        }
    }
}
