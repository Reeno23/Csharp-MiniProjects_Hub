using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSegments
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seg1 = { 3, 5 };
            int[] seg2 = { 7, 5 };
            List<int> list = new List<int>();

            for(int i=0; i<seg1.Length; i++)
            {
                for(int j=0; j<seg2.Length; j++) {

                    if (seg1[i] == seg2[j])
                    {
                        list.Add(seg1[i]);
                    }

                    foreach (int a in list)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
               
            

        }
    }
}
