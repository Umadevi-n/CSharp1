using System;
using System.Collections;
using System.Text;


namespace Queue1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue obj = new Queue();
            obj.Enqueue("Uma");
            obj.Enqueue("Devi");
            obj.Enqueue("Mantena");
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
