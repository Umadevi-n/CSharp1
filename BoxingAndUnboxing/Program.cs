using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int stackVar = 12;

            //Boxing: Converting value type to reference type
            object boxedVar = stackVar;

            //Unboxing: Converting reference type to value type
            int unBoxed = (int)boxedVar;
            Console.WriteLine("{0}, {1}", boxedVar, unBoxed);
            Console.ReadLine();

        }
    }
}
