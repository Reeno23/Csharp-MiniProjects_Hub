using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1024;
            int sum = 0;

            for (int i = 2; i <= n; i*=2)
            {
                sum += i;

            }

            Console.Write(sum);

        }
    }
}
