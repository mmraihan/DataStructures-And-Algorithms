using System;

namespace BinarySearch
{
    class Program
    {
        public int binarySearch( int [] A, int n, int key)
        {
            int left = 0;
            int right = n - 1;

            while (left<=right)
            {
                int mid = (left + right) / 2;
                if (key == A[mid])
                    return mid;
                else if (key < A[mid])
                    right = mid - 1;

                else if (key > A[mid])
                    left = mid + 1;         
            }
            return -1;
        }
        static void Main(string[] args)
        {

            Program search = new Program();
            int[] A = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            var result= search.binarySearch(A, 10, 1010);
            Console.WriteLine("Result: " + result);
        }
    }
}
