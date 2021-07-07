using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class UC1_CalculateLength
    {
        public static void CalculateLength()
            {
            double x1, x2, y1, y2;
            double a1, a2, b1, b2;
            double length;
            Console.WriteLine("Enter the points of line1");
            Console.WriteLine("Enter points (x1,y1): ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter points (x2,y2): ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            length = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));


            Console.WriteLine("The length between two points is " + length);
            }
        }
    }

