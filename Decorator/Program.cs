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
            IReport report;
            int ans;
            while (true)
            {
                Console.WriteLine("What kind of report do you want to generate? (1 - user report, 2 - sales report)");
                ans = Convert.ToInt32(Console.ReadLine());
                if (ans == 1)
                {
                    report = new UserReport();
                    break;
                }
                else if (ans == 2)
                {
                    report = new SalesReport();
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Try again.");
                }
            }

            Console.WriteLine("Would you like to add filter by date?(0 - yes, anything else - no)");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 0)
            {
                report = new DateFilterDecorator(report);
            }

            Console.WriteLine("Would you like to add sorting by date?(0 - yes, anything else - no)");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 0)
            {
                report = new SortingDateDecorator(report);
            }

            Console.WriteLine("Would you like to add sorting by sales amount?(0 - yes, anything else - no)");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 0)
            {
                report = new SortingSalesAmountDecorator(report);
            }

            Console.WriteLine("Would you like to add opportunity to export into csv?(0 - yes, anything else - no)");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 0)
            {
                report = new CsvExportDecorator(report);
            }

            Console.WriteLine("Would you like to add opportunity to export into pdf?(0 - yes, anything else - no)");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 0)
            {
                report = new PdfExportDecorator(report);
            }

            Console.WriteLine($"Result: {report.Generate()}");
        }
    }
}
