using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class PdfExportDecorator : ReportDecorator
    {
        public PdfExportDecorator(IReport report) : base(report) { }

        public override string Generate()
        {
            return base.Generate() + " can export into pdf";
        }
    }
}
