using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.sms
{
    public class RobiSmsProvider : ISmsProvider
    {
        public void sendSms(string text, string phoneNumber)
        {
            Console.WriteLine("Sending sms via Robi");
            Console.WriteLine($"{text}-{phoneNumber}");
        }
    }
}
