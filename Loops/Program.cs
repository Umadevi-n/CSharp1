using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInterger = new int[4];
            myInterger[0] = 1;
            myInterger[1] = 2;
            myInterger[2] = 3;
            myInterger[3] = 4;
            int total = 0;
            foreach (int i in myInterger)
            {
                total += i;
            }
            Console.WriteLine(total);
            Console.ReadLine();

            ////Same using For                           
            for (int i = 0; i < myInterger.Length; i++)
            {
                total += myInterger[i]; ;
            }
            Console.WriteLine(total);
            Console.ReadLine();

        }
    }
}
