using System;

namespace LineComparisionUsingOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation Program ");
            Console.WriteLine(".................................................");

            //UC_1.CalculateLength();
           // UC_2.CompareTheLength();
           // UC_3.CompareTheLength();
            
            UC_4 uc4 = new UC_4();
            uc4.EnterInput();
            uc4.CalculateTheLength();
            uc4.CompareThelength();


            Console.ReadLine();

        }
    }
}
