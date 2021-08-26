using System;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 10; arr[1] = 14; arr[2] = 15; arr[3] = 14; arr[4] = 11;

            Console.WriteLine("Array elements before sorting");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Array.Sort(arr);

            Console.WriteLine("Array elements after sorting");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
    }
}
