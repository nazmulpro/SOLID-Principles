using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneApp.interfaces;

namespace PhoneApp
{
    public class SamsungA30 : Phone,IPhoto
    {
        public override string Call()
        {
            return "SamsungA30 - Making a call";
        }

        public override string SendMessage()
        {
            return "SamsungA30 - Message is being sent";
        }

        public string TakePhoto()
        {
            return "SamsungA30 - Photo was taken";
        }
    }
}
