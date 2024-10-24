using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Challenge
{
    class Program
    {
        struct Point {
            public int X;
            public int Y;

            public Point(int x, int y) {
                X = x;
                Y = y;
            }
        }

        
        static Point GetRandomPoint() {
                Random rand = new Random();
                return new Point(rand.Next(-100,101), rand.Next(-100,101));
        }

        static void Main(string[] args) {
            Point point1;
            point1 = GetRandomPoint();

            Console.WriteLine($"Your Point: ({point1.X}, {point1.Y})\nX Coordinate: {point1.X}\nY Coordinate: {point1.Y}\n");

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}