using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usecase_LineMethod2
{
    internal class LinecheckMethod2
    {
        public void Coordinates()
        {
            double[] length = new double[2];

            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Enter value X1");
                double x1=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter value Y1");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter value X2");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter value Y2");
                double y2 = Convert.ToDouble(Console.ReadLine());

                length[i]=Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
            Console.WriteLine("Length of line1 is:" + length[0]);
            Console.WriteLine("Length of line2 is:" + length[1]);

            Console.WriteLine("Is given two lines are equal?:" + " " + length[0].Equals(length[1]));

            int compareLine = length[0].CompareTo(length[1]);

            if (compareLine > 0)
            {
                Console.WriteLine("Line 1 is bigger than Line 2");
            }
            else if (compareLine < 0)
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
