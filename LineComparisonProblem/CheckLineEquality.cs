using System;

namespace LineComparisonProblem
{
    class UC_1_LengthOfLine
    {
        public void FindLengthOfLine()
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Enter value of x1 and y1 for line");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of x2 and y2 for line");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("length of Line is : " + length);
        }
    }
}