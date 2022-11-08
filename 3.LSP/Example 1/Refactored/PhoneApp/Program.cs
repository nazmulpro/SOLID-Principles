namespace PhoneApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone aIphone = new Iphone();
            SamsungA30 a30 = new SamsungA30();
            Nokia1100 aNokia1100 = new Nokia1100();


            Console.WriteLine(aIphone.Call());
            Console.WriteLine(a30.TakePhoto());
            Console.WriteLine(aNokia1100.SendMessage());
            Console.ReadKey();
        }
    }
}