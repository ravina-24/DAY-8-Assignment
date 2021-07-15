using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionUsingOOPS
{
   public  class UC_1
    {
            public static void CalculateLength()

           {


            double x1, x2, y1, y2;

            
            Console.Write("Enter the co-ordinate of x1  :  ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the co-ordinate of x2  :   ");
            x2 = double.Parse(Console.ReadLine());


            Console.Write("Enter the co-ordinate of y1  :   ");
            y1 = double.Parse(Console.ReadLine());


            Console.Write("Enter the co-ordinates of y2 :   ");
            y2 = double.Parse(Console.ReadLine());



            double Length;


            Length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));


            Console.WriteLine("Length of  a Line   :" + Length);

         
           }
    }
}
