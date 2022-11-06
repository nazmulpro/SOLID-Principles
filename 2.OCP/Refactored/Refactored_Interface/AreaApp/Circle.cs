using AreaApp.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaApp
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
