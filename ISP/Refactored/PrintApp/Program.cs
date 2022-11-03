using PrintApp.Interfaces;

namespace PrintApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HPPrinter printer = new HPPrinter();
            printer.FaxContent("Fax");

            CanonPrinter canonPrinter = new CanonPrinter();
            canonPrinter.ScanContent("Scan");
        }
    }
}