using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            double a = n / 2;
            double root = 0;

            
            while(a*a != n) 
            {
                if (a * a < n)
                {
                    a+=.1;
                }
                else if(a*a > n) 
                { a-=.1; }

                root = a;
            }
            Console.Write(root);


        }
    }
}
