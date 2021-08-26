using System;

namespace MaxAndMin

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The minimum value of byte is {0},maximam value of byte is {1}", byte.MinValue, byte.MaxValue);

            ////How to find size data type
            Console.WriteLine("The size of of byte is {0}", sizeof(byte));

            //short
            Console.WriteLine("The minimum value of short is {0},maximam value of short is {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("The size of of short is {0}", sizeof(short));

            //int
            Console.WriteLine("Interger Min Value:" + sbyte.MinValue + "  Integer Max Value:" + sbyte.MaxValue);
            Console.ReadLine();

        }
    }
}
