using System;

namespace Usecase_LineMethod2
{
    internal class Line
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            LinecheckMethod2 methodCall=new LinecheckMethod2();
            methodCall.Coordinates();
        }
    }
}
