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
            Console.WriteLine("Length of line1 is:" + lengthofLine1);
        }
    }
}
