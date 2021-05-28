using Cmd.App;
using Cmd.App.Academy;
using Cmd.App.Automobile;
using Cmd.App.Shapes;
using Cmd.Core;
using System;

namespace Program
{
    public class Tester
    {
        public static void Main()
        {
            var rectangle = new Rectangle(89, 90);

            Console.WriteLine("Area of a rectangle = {0}", rectangle.GetArea());
            var circle = new Circle(90, 90, 7);

            var area = circle.GetArea();
            Console.WriteLine("Area of a circle = {0}\t-\t{1}", area.Item1, area.Item2);

            //Car car = new Car();
            //car.SetBrand("Toyota");
            //car.Honk();
            //Car car2 = new Car();
            //car2.SetBrand("Mercedes");

            //Console.WriteLine(car.PrintCarBrand());
            //Console.WriteLine(car2.PrintCarBrand());

            Console.WriteLine("End of Main");
        }
    }
}
