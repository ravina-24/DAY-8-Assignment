using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionUsingOOPS
{
    public class UC_4

    {


        double x1, x2, y1, y2;
        double f1, f2, g1, g2;
        double Length1, Length2;

        public void EnterInput()
        {

            //Entering the inputs of co-ordinates of line 1 and line 2 


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

            Console.Write("Enter the co-ordinates of g1 :   ");
            g1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the co-ordinate of g2  :   ");
            g2 = double.Parse(Console.ReadLine());
        }

        public void CalculateTheLength()
        {


            // Calculating the lenght of line 1 and line 2 


            Length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Length2 = Math.Sqrt((f2 - f1) * (f2 - f1) + (g2 - g1) * (g2 - g1));


            Console.WriteLine("Length of  a Line 1  :" + Length1);
            Console.WriteLine("Length of a Line  2  :" + Length2);
        }

        public void CompareThelength()
            
        {

            //comparing the lengths using CompareTo method 

            if (Length1.CompareTo(Length2) > 0)
            {
                Console.WriteLine("Length of line 1 is greater than Length of line 2 ");


            }
            else if (Length2.CompareTo(Length1) > 0)
            {
                Console.WriteLine("Lenght of line 2 is greater than Length of line 1 ");

            }
            else
            {
                Console.WriteLine("Two Lines are equal ");
            }

        }


    }

}
