using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Insertion Sort by Chris Hume on 3/20/15.
// For CIS3350: Algorithms.

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<int> Shaq = new List<int>();

            // Filling up the unsorted list quickly.
            for(int i=0; i<10; i++) 
            {
                int ran = rng.Next(15);
                Shaq.Add(ran);
            }

            int length = Shaq.Count;
            int j = 0;
            int temp = 0;

            for (int i = 0; i < length; i++)
            {
               temp = Shaq[i];
               j = i;
               while(j > 0 && (Shaq[j-1] > temp)) 
               {
                   Shaq[j] = Shaq[j - 1];
                   j--;
               }
               Shaq[j] = temp;
            }

            foreach (int item in Shaq)
            {
                Console.Write("{0}\n", item);
            }
            Console.ReadKey();
        }
    }
}
