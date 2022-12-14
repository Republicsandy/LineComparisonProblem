using System;

namespace LineComparisonProblem
{
   
    class UC_2_CheckEquality
    {
        public void CheckEquality()
        {
            {
                int x1, x2, y1, y2, x3, y3, x4, y4;

                Console.WriteLine("Enter values x1 and y1 for Line 1");
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter values x2 and y2 for Line 1");
                x2 = Convert.ToInt32(Console.ReadLine());
                y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter values x1 and y1 for Line 2");
                x3 = Convert.ToInt32(Console.ReadLine());
                y3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter values x2 and y2 for Line 2");
                x4 = Convert.ToInt32(Console.ReadLine());
                y4 = Convert.ToInt32(Console.ReadLine());

                double lenthOfFirstLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double lenthOfSecondLine = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

                if (lenthOfFirstLine == lenthOfSecondLine)
                    Console.WriteLine("Lines are equal in length.");
                else
                    Console.WriteLine("Lines are not equal in length.");
            }
        }
    }
}
