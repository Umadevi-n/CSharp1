using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Dint = new Dictionary<int, string>();
            // Add some elements to the dictionary.
            Dint.Add(1, "Student 1");
            Dint.Add(2, "Student 2");
            Dint.Add(3, "Student 3");
            Dint.Add(4, "Student 4");
            // The Add method throws an exception if the new key is  
            // already in the dictionary. 
            //Dint.Add(3, "Student 5");
            // The Item property is another name for the indexer, so you  
            // can omit its name when accessing elements. 
            Console.WriteLine("For key = \"1\", value = {0}.", Dint[1]);
            Console.ReadLine();

        }
    }
}
