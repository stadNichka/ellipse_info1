using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo btn;
            do
            {
                Console.WriteLine("\nCoordinates of point 1(central):");
                Console.WriteLine("x1:");
                double x1 = double.Parse(Console.ReadLine());
                Console.WriteLine("y1:");
                double y1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Coordinates of point 2:");
                double x2 = double.Parse(Console.ReadLine());
                Console.WriteLine("y2:");
                double y2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Coordinates of point 3:");
                double x3 = double.Parse(Console.ReadLine());
                Console.WriteLine("y3:");
                double y3 = double.Parse(Console.ReadLine());

                double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double b = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

                Console.WriteLine("\nEllipse area:");

                double area = Math.PI * a * b;
                Console.WriteLine(area);

                Console.WriteLine("\nPerimeter of the ellipse:");

                double P = 2 * Math.PI * (Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)))/2);
                Console.WriteLine(P);

                Console.WriteLine("\nType of the ellipse:");
                if (a == b)
                {
                    Console.WriteLine("Circle");
                }
                else
                {
                    Console.WriteLine("Ellipse");
                }

                Console.WriteLine("\nTo exit press Esc / To continue press any other key");
                btn = Console.ReadKey();

            } while (btn.Key != ConsoleKey.Escape);
        }
    }
}
