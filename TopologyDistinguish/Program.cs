using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopologyDistinguish
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[4, 4] { { 1, 1, 1, 1 }, 
                                            { 0, 1, 1, 0 }, 
                                            { 1, 0, 0, 1 }, 
                                            { 0, 1, 1, 0 } };

            bool ring = false;
            bool star = false;
            bool full = false;
            int temp = 0;
            int temp2 = 0;
            int len = matrix.GetLength(0);
            

            for (int i = 1; i < len; i++ )
            {
                temp += matrix[0, i];
            }

            if (temp == 2)
            {
                ring = true;
                Console.Write("Ring: {0}\n", ring);
            }
            if(temp == 1)
            {
                star = true;
                Console.Write("Star: {0}\n", star);
            }

            for (int i = 0; i < len; i++)
            {
                temp2 += matrix[1, i];
            }

            if (temp == temp2)
            {
                full = true;
                Console.Write("Full: {0}\n", full);
            }
            else
            {
                star = true;
                Console.Write("Star: {0}\n", star);
            }
        }
    }
}
