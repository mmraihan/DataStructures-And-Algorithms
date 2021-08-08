using System;

namespace LinearSearch
{
    class Search
    {
        public int linearSearch(int[] A, int n, int key)
        {
            int index = 0;
            while (index<n)
            {
                if (A[index] == key)
                    return index;
                index = index + 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Search s = new Search();
            int[] A = { 84, 20, 44, 33, 22 };
            int found= s.linearSearch(A, 5, 22);
            Console.WriteLine("Result: " +found);
            Console.ReadKey();

        }
    }
}
