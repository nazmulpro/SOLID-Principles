using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp
{
    public class Nokia1100 : Phone
    {
        public override string Call()
        {
            return "Nokia1100 - Making a call";
        }

        public override string SendMessage()
        {
            return "Nokia1100 - Message is being sent";
        }

        public override string TakePhoto()
        {
            throw new NotImplementedException();
            //return "No Camera!";

        }
    }
}
