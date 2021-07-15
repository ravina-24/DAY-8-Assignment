using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionUsingOOPS
{
   public  class UC_2
    {

        public static void CompareTheLength()
        {


            double x1, x2, y1, y2;
            double f1, f2, g1, g2;

            Console.Write("Enter the co-ordinate of x1  :   ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the co-ordinate of x2  :   ");
            x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the co-ordinate of y1  :   ");
            y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the co-ordinates of y2 :   ");
            y2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the co-ordinates of f1 :   ");
            f1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the co-ordinates of f2 :   ");
            f2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the co-ordinates of g1 :    ");
            g1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the co-ordinate of g2  :    ");
            g2 = double.Parse(Console.ReadLine());




            double Length1, Length2;


            Length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Length2 = Math.Sqrt((f2 - f1) * (f2 - f1) + (g2 - g1) * (g2 - g1));


            Console.WriteLine("Length of  a Line 1  :" + Length1);
            Console.WriteLine("Length of a Line  2  :" + Length2);


            //Comparing the length of line 1 and two if they are equal or not 

            if ( Length1.Equals(Length2))
            {
                Console.WriteLine("Two lines are equal ");

            }
            else
            {
                Console.WriteLine("Two Lines are not equal ");
            }





        }





    }
}
