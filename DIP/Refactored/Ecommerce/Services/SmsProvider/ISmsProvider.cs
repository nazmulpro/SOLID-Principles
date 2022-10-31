using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.sms
{
    public interface ISmsProvider
    {
        void sendSms(string text, string phoneNumber);
    }
}
