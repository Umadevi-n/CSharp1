using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[4];
            arr[0] = "UmaDevi";
            arr[1] = 5;
            arr[2] = 5.55;
            arr[3] = 'K';

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
