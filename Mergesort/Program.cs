using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

// Mergesort by Chris Hume on 3/27/15
// For CIS3350: Analysis of Algorithms

namespace Mergesort
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Path of text file of unsorted numbers we created and need to use.
            string numFilePath = Path.Combine(Environment.CurrentDirectory, @"Text Files\SortMe.txt");
            //MakeTextFile(numFilePath); // Call if SortMe.Txt doesn't exist or is empty.
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

            // Now onto the actual Mergesort code.
            int len = A.Length;
            int left = 0;
            Mergesort(A, left, (len - 1));

            // Output sorted list
            foreach (int item in A)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        // Sort subarrays
        static void Mergesort(int[] A, int left, int right)
        {
        if(A.Length == 1) 
        {
            return;
        }

        if (left < right)
        {
            int mid = (left+right)/2;
            Mergesort(A, left, mid);
            Mergesort(A, mid + 1, right);
            Merge(A, left, mid, right);
        }
    }

        // Merge sorted subarrays
        static void Merge(int[] A, int left, int mid, int right)
        {
            int leftLength = (mid-left+1);
            int rightLength = (right-mid);
            int[] B = new int[leftLength + 1];
            int[] C = new int[rightLength + 1];

            for(int i=0; i<leftLength; i++) 
            {
                B[i] = A[left + i];
            }

            for(int j=0; j<rightLength; j++)
            {
                C[j] = A[mid + j + 1];
            }
            B[leftLength] = Int32.MaxValue;
            C[rightLength] = Int32.MaxValue;
            int indexI = 0;
            int indexJ = 0;

            for (int k = left; k <= right; k++)
            {
                if(B[indexI] <= C[indexJ]) 
                {
                    A[k] = B[indexI];
                    indexI++;
                }
                else
                {
                    A[k] = C[indexJ];
                    indexJ++;
                }
            }
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
