using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintApp
{
    public class HPPrinter : IPrinterTasks
    {
        public void PrintContent(string printContent)
        {
            Console.WriteLine("Print Content");
        }

        public void ScanContent(string printContent)
        {
            Console.WriteLine("Scan Content");
        }

        public void FaxContent(string printContent)
        {
            Console.WriteLine("Fax Content");
        }

        public void PhotoCopyContent(string printContent)
        {
            Console.WriteLine("PhotoCopy Content");
        }
    }
}
