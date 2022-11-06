namespace PrintApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HPPrinter hpPrinter = new HPPrinter();
            hpPrinter.PrintContent("Print");

            CanonPrinter canonPrinter = new CanonPrinter();
            canonPrinter.PhotoCopyContent("Photo Copy");
        }
    }
}