using System;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");

            Console.WriteLine("Choose a number to go to the respective problem");
            Console.WriteLine("1 for find the length of line");
            Console.WriteLine("2 for check the line is equal or not");
            Console.WriteLine("3 for find the difference of the line");

            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {

                case 1:
                    UC_1_LengthOfLine lengthofline = new UC_1_LengthOfLine();
                    lengthofline.FindLengthOfLine();
                    break;
                case 2:
                    UC_2_CheckEquality checkequality = new UC_2_CheckEquality();
                    checkequality.CheckEquality();
                    break;
                case 3:
                    UC_3_CompareTowLines linecompare = new UC_3_CompareTowLines();
                    linecompare.CompareTowLines();
                    break;
            }

        }
    }
}
