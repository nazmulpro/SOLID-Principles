using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp
{
    public abstract class Phone
    {
        public abstract string Call();
        public abstract string SendMessage();
        public abstract string TakePhoto();
    }
}
