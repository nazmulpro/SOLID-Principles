using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintApp
{
    public interface IPrinterTasks
    {
        void PrintContent(string printContent);
        void ScanContent(string printContent);
        void FaxContent(string printContent);
        void PhotoCopyContent(string printContent);
    }
}
