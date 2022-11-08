namespace PhoneApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iphone aIphone = new Iphone();
            SamsungA30 a30 = new SamsungA30();
            Nokia1100 aNokia1100 = new Nokia1100();


            Console.WriteLine(aIphone.Call());
            Console.WriteLine(a30.SendMessage());
            Console.WriteLine(aNokia1100.TakePhoto());

            Console.ReadKey();
        }
    }
}