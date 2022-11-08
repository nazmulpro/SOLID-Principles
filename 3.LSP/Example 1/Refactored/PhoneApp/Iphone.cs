using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneApp.interfaces;

namespace PhoneApp
{
    public class Iphone : Phone,IPhoto
    {
        public override string Call()
        {
            return "Iphone - Making a call";
        }

        public override string SendMessage()
        {
            return "Iphone - Message is being sent";
        }
        public string TakePhoto()
        {
            return "Iphone - Photo was taken";
        }
    }
}
