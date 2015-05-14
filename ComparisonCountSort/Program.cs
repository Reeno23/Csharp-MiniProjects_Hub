using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonCountSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {60, 35, 81, 98, 14, 47};
            int[] S = new int [6];
            int[] count = new int [6];

            for(int i=0; i<A.Length-1; i++)
            {
                count[i] = 0;
            }

            for(int i=0; i<A.Length-2; i++)
            {
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    if (A[i] < A[j])
                    {
                        count[j] = count[j] + 1;
                    }
                    else
                    {
                        count[i] = count[i] + 1;
                    }
                }
            }
            for(int i=0; i<A.Length-1; i++ )
            {
                S[count[i]] = A[i];
            }

            foreach (int a in S)
            {
                Console.WriteLine(a);
            }
        }
    }
}
