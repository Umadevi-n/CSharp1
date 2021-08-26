using System;
using System.Collections;
using System.Text;


namespace HashTable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable obj = new Hashtable();

            obj.Add(1, "Uma");
            obj.Add(2, "Devi");
            obj.Add(3, "Mantena");

            for (int i = 1; i <= obj.Count; i++)
            {
                Console.WriteLine("The value for the Key is {0}", obj[i]);
            }
            Console.ReadLine();

        }
    }
}
