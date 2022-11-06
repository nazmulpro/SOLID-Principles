using AreaApp.interfaces;

namespace AreaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Using Interface

            IShape[] shapes = {
                new Rectangle { Width =20, Height =10},
                new Circle { Radius = 10},
                new Triangle { Width = 10,Height = 10},
            };

            AreaCalculator areaCalculator = new AreaCalculator();
            var totalArea =areaCalculator.Area(shapes);
            Console.WriteLine(totalArea);


        }
    }
}