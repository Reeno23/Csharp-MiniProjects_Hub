using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

// Quicksort by Chris Hume on 3/27/15
// For CIS3350: Analysis of Algorithms

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path of text file of unsorted numbers we created and need to use.
            string numFilePath = Path.Combine(Environment.CurrentDirectory, @"Text Files\SortMe.txt");
            //MakeTextFile(numFilePath); Call if SortMe.Txt doesn't exist or is empty.
            string numString = File.ReadAllText(numFilePath);
            string[] splitString = numString.Split(',');

            int[] A = new int[1001];
            int x = 0;

            // Fill array A with file values.
            foreach (string s in splitString)
            {
                bool res = int.TryParse(s, out A[x]);
                x++;
            }

            // Now onto the actual Quicksort code.
            int len = A.Length;
            int left = 0;
            Quicksort(A, left, (len - 1));

            // Output sorted list
            foreach (int item in A)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static int Partition(int[] A, int left, int right)
        {
            int pivot = A[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (A[j] <= pivot)
                {
                    i++;
                    Swap(A, i, j);
                }
            }
            Swap(A, i + 1, right);
            return i + 1;
        }

        static void Quicksort (int[] A, int left, int right) 
        {
            int pivotIndex = 0;
            if (left < right)
            {
                pivotIndex = Partition(A, left, right);
                Quicksort(A, left, pivotIndex - 1);
                Quicksort(A, pivotIndex + 1, right);
            }
        }

        static void Swap(int[] ph, int a, int b)
        {
            int temp = ph[a];
            ph[a] = ph[b];
            ph[b] = temp;
        }

        // Call in main to create a 1000 int text file if one doesn't exist.
        static void MakeTextFile(string path)
        {
            Random ran = new Random();
            for (int i = 0; i < 1000; i++)
            {
                // Generate random number from 0-29
                int num = ran.Next(30);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                {
                    file.Write(num + ", ");
                }
            }
        }
    }
}
