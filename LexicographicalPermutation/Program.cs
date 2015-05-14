using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lexicographical Permutation by Chris Hume on 3/20/15.
// For CIS3350: Algorithms.

namespace LexicographicalPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Feel free to change the initial permutation array here.
            int[] P = new int[6] { 6, 3, 4, 5, 2, 1 };
            //[6] { 6, 3, 4, 5, 2, 1 };
            //[8] {4, 6, 3, 1, 8, 7, 5, 2};
            bool go = true;

            var spaces = new String(' ', 7);
            Console.Write("P started from the bottom as: \n");
            Console.Write("\t{0}", spaces);
            foreach (int item in P)
            {
                Console.Write("{0} ", item);
            }
            Console.Write("\n");
            
            while (go == true)
            {
                go = false;
                for (int q = 0; q < P.Length - 1; q++)
                {
                    if (P[q] < P[q + 1])
                    {
                        go = true;
                    }
                }

                // If the array doesn't have two elements in increasing order, stop everything. 
                if (go == false)
                {
                    Console.Write("Drake jokes..\n");
                    Console.ReadKey();
                    return;
                    
                }

            // Our chunk of starting variables that reset each full iteration.
            int length = P.Length;
            int i = length - 1;
            int j = length - 1;
            int tempI = 0;
            int tempJ = 0;
            int temp = 0;
                    
            // Find our i.
            while (i > 0)
            {
                if (P[i - 1] < P[i])
                {
                    tempI = P[i - 1];
                    break;
                }
                i--;
            }

            // Find our j.
            while (j > 0)
            {
                if (P[j] > tempI)
                {
                    tempJ = P[j];
                    break;
                }
                j--;
            }

            // Swap i & j.
            P[j] = tempI;
            P[i - 1] = tempJ;

            // Reverse everything after i.
            while (length > i)
            {
                temp = P[length-1];
                P[length-1] = P[i];
                P[i] = temp;
                i++;
                length--;
            }

            Console.Write("P is now here: ");
            foreach (int item in P)
            {
                Console.Write("{0} ", item);
            }
            Console.Write("\n");
            
            }
            
        } 
    }
}
