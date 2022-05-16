using System;

namespace UseCase_Line
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Linecheck length = new Linecheck();
            double lengthofLine1 = length.Coordinates(5, 8, 5, 18);
            double lengthofLine2 = length.Coordinates(5, 8, 5, 19);
            Console.WriteLine("Length of line1 is:" + lengthofLine1);
            Console.WriteLine("Length of line2 is:" + lengthofLine2);

            Console.WriteLine("Is given two lines are equal?:" + " " + lengthofLine1.Equals(lengthofLine2));
        }
    }
}
