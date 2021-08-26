using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string DayName = "Wednesday";

            //if else if
            if (DayName == "Sunday")
                Console.WriteLine("The Day is Sunday");
            else if(DayName == "Monday")
                Console.WriteLine("The Day is Monday");
            else if(DayName == "Monday")
                Console.WriteLine("The Day is Monday");
            else if(DayName == "Tuesday")
                Console.WriteLine("The Day is Tuesday");
            else if(DayName == "Wednesday")
                Console.WriteLine("The Day is Wednesday");
            else if(DayName == "Thursday")
                Console.WriteLine("The Day is Thursday");
            else if(DayName == "Friday")
                Console.WriteLine("The Day is Friday");
            else if(DayName == "Saturday")
                Console.WriteLine("The Day is Saturday");
            else
                Console.WriteLine("Please enter proper day");

            Console.ReadLine();

            //switch:which provides an easy way to check multiple statements

            switch (DayName)
            {
                case "Sunday":
                    Console.WriteLine("The Day is Sunday");
                    break;
                case "Monday":
                    Console.WriteLine("The Day is Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("The Day is Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("The Day is Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("The Day is Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("The Day is Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("The Day is Saturday");
                    break;

                default:
                    Console.WriteLine("Please enter proper day");
                    break;

            }

            Console.ReadLine();



        }
    }
}
