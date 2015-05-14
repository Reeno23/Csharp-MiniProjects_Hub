using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclids
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 31415;
            int n = 14142;
            int r;

            while (n != 0)
            {
                r = m % n;
                m = n;
                n = r;
                Console.WriteLine(m);
            }
            
        }
    }
}
