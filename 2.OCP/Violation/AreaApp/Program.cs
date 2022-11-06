namespace AreaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Object[] shapes = {
                new Rectangle { Width =20, Height =10},
                new Circle { Radius = 10},
            };

            AreaCalculator areaCalculator = new AreaCalculator();
            var totalArea =areaCalculator.Area(shapes);
            Console.WriteLine(totalArea);

            // Rectangle aRectangle = new Rectangle(10,20);
            //Rectangle aRectangle1 = new Rectangle(20,20);
            // AreaCalculator areaCalculator = new AreaCalculator();
            //var area =areaCalculator.Area(new object[] { aRectangle });


        }
    }
}