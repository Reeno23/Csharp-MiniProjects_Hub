using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ValueAtX
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] coef = new int[9];
            int n = coef.Length;
            for (int i = 0; i < n; i++)
            {
                coef[i] = rand.Next(10);
            }

            int poly = 0;
            int x = 6;
            int expo = 1;

            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                expo *= x;
                temp = expo * coef[i];
                poly += temp;

                Console.WriteLine(poly);
            }
            


        }
    }
}
