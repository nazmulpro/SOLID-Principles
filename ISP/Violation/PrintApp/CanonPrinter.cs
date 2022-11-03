using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintApp
{
    public class CanonPrinter : IPrinterTasks
    {
        public void PrintContent(string printContent)
        {
            Console.WriteLine("Print Content");
        }

        public void ScanContent(string printContent)
        {
            Console.WriteLine("Print Content");
        }

        public void FaxContent(string printContent)
        {
            throw new NotImplementedException();
        }

        public void PhotoCopyContent(string printContent)
        {
            Console.WriteLine("No PhotoCopy !!!");
            //throw new NotImplementedException();
        }
    }
}
