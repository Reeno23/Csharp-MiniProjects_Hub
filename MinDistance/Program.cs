using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {2, 4, 5, 6, 20, 25};
            int inf = 10000000;
            int j = 1;


            for(int i=0; i<A.Length-1; i++) {
                
                if (i != j && (A[i] - A[j] < inf))
                {
                    
                    inf = (A[i] - A[j]);
                    
                }

                j++;
                }
           
            Console.WriteLine(inf);
        }
    }
}
