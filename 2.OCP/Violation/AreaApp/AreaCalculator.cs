using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaApp
{
    public class AreaCalculator
    {
        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rect = (Rectangle)shape;
                    area += rect.Width * rect.Height;
                }

                if (shape is Circle)
                {
                    Circle circle = (Circle)shape;
                    area += (circle.Radius * circle.Radius)* Math.PI;
                }
            }
            return area;
        }
    }
}
