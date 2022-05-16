using System;

namespace UseCase_Line
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Linecheck length = new Linecheck();
            double lengthofLine1 = length.Coordinates(5, 8, 5, 22);
            double lengthofLine2 = length.Coordinates(5, 8, 5, 20);
            Console.WriteLine("Length of line1 is:" + lengthofLine1);
            Console.WriteLine("Length of line2 is:" + lengthofLine2);

            Console.WriteLine("Is given two lines are equal?:" + " " + lengthofLine1.Equals(lengthofLine2));

            int compareLine=lengthofLine1.CompareTo(lengthofLine2);

            if(compareLine>0)
            {
                Console.WriteLine("Line 1 is bigger than Line 2");
            }
            else if(compareLine<0)
            {
                Console.WriteLine("Line 1 is smaller than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is equal to Line 2");
            }
        }
    }
}
