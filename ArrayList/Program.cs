using System;
using System.Collections;
using System.Text;


namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add("Uma");
            obj.Add(10);
            obj.Add(10.123);
            obj.Insert(2, "Devi");


            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
