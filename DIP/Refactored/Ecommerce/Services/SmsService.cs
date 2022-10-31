using Ecommerce.Services.sms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class SmsService
    {
        private ISmsProvider smsProvider;

        public SmsService(ISmsProvider smsProvider)
        {
            this.smsProvider = smsProvider;
        }
        public void sendTextSms(string text, string phoneNumber)
        {
            smsProvider.sendSms(text, phoneNumber);
        }
    }
}
