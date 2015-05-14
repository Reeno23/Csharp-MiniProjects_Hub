using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Can only use addition, subtraction, multiplication, division, rounding, & mod.

namespace PrimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Double input = 701;  // Must be greater than 3.

            String ans = PrimeTest(input);
            Console.Write(ans);


        }

        static String PrimeTest(double A)
        {
            String result = "";


            if (A % 2 == 0)
            {
                // We found an even number. We're done.
                result = "Composite found.";
            }
            else if (A == 5 || A == 7)
            {
                // Narrow down off the bat.
                result = "Prime found.";
            }
            else if (A % 3 == 0 | A % 5 == 0 || A % 7 == 0)
            {
                result = "Composite found.";
            }
            else
            {
                result = "Prime found.";
            }


            return result;
        }
    }
}
