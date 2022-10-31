using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class SmsService
    {
        public void sendSms(string text, string phoneNumber)
        {
            Console.WriteLine("Sending sms via GP");
            Console.WriteLine(text);
            Console.WriteLine(phoneNumber);
           
           
        }
    }
}
