using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class UC2_EqualityOfLines
    {
        public static void CalculateLength()
        {
            double x1, x2, y1, y2;
            double a1, a2, b1, b2;
            double length1, length2;
            Console.WriteLine("Enter the points of line1");
            Console.WriteLine("Enter points (x1,y1): ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter points (x2,y2): ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the points of line2");
            Console.WriteLine("Enter points (a1,b1): ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter points (a2,b2): ");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            length1 =Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            length2 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            if (length1 == length2)
            {
                Console.WriteLine("Both  lines are equal in Length");
            }
            else
            {
                Console.WriteLine("The Lines are unequal in length");
            }
        }
    }
}
       
