using System;
using System.Collections;
using System.Text;


namespace Stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack obj = new Stack();
            obj.Push("Uma");
            obj.Push("Devi");
            obj.Push("Mantena");
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
